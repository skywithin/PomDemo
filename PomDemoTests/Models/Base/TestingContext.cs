using PomDemoTests.Models.Pages;

namespace PomDemoTests.Models.Base;

public partial class TestingContext : IAsyncDisposable
{
    public static readonly Uri RootUri = new Uri("http://localhost:5257");

    private readonly IPlaywright _playwright;
    private readonly IBrowser _browser;
    private readonly IBrowserContext _browserContext;
    private readonly IPage _page;
    private BaseComponentObject? _currentPageComponent;


    public IPage Page => _page;

    public TestingContext()
    {
        _playwright = Microsoft.Playwright.Playwright.CreateAsync().Result;
        _browser = _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false }).Result;
        _browserContext = _browser.NewContextAsync().Result;
        _page = _browserContext.NewPageAsync().Result;
        _page.FrameNavigated += PageFrameNavigated;
    }

    private void PageFrameNavigated(object? sender, IFrame args)
    {
        // Check the args.Url against the list of component to url mappings
        // update the current component to an instance of that Component

        //codegen
        //if (args.Url == Routes.ClientViewPermits)
        //{
        //    _currentPageComponent = ClientViewPage() { Page = _page };
        //}

        var path = args.Url.Replace(RootUri.AbsoluteUri, "/");

        switch (path)
        {
            case "/servers":
                _currentPageComponent = new ServersCom() { Page = _page };
                break;

                //default:
                //    throw new NotImplementedException($"No component mapping found for URL: {args.Url}");
        }
    }

    public async Task<ServersCom> RouteServers()
    {
        return await NavigateToRoute<ServersCom>("servers");
    }

    private async Task<T> NavigateToRoute<T>(string path) where T : BaseComponentObject, new()
    {
        var url = new Uri(RootUri, path).AbsoluteUri;
        await _page.GotoAsync(url);

        if (!TryGetCurrentPage<T>(out var pageComponent))
        {
            throw new InvalidOperationException($"No page component of type {typeof(T).Name} found at route {path}.");
        }
        return pageComponent!;
    }

    public bool TryGetCurrentPage<T>(out T? pageComponent) where T : BaseComponentObject, new()
    {
        pageComponent = _currentPageComponent as T;
        return pageComponent != null;
    }

    public T GetCurrentPage<T>() where T : BaseComponentObject, new()
    {
        if (TryGetCurrentPage<T>(out var pageComponent))
        {
            return pageComponent!;
        }

        throw new InvalidOperationException($"Current page component is not of type {typeof(T).Name}");
    }

    public async ValueTask DisposeAsync()
    {
        await _browser.CloseAsync();
    }
}
