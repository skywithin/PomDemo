using Microsoft.Playwright;

namespace PomDemoTests.Models;

public class CounterPage
{
    private readonly IPage _page;
    private readonly ILocator _button;
    private readonly ILocator _status;

    public string Url { get; }

    public CounterPage(IPage page, string baseUrl)
    {
        _page = page;
        _button = page.GetByRole(AriaRole.Button, new() { Name = "Click me" });
        _status = page.GetByRole(AriaRole.Status);

        Url = $"{baseUrl}/counter";
    }

    public async Task<CounterPage> GotoAsync()
    {
        await _page.GotoAsync(Url);

        return this;
    }

    public async Task<CounterPage> ClickIncrementAsync()
    {
        await _button.ClickAsync();
        return this;
    }

    public async Task<int> GetCountAsync()
    {
        var text = await _status.InnerTextAsync();

        // e.g. "Current count: 1"
        var parts = text.Split(':');

        return int.Parse(parts[^1].Trim());
    }
}

//using Microsoft.Playwright;
//using System;
//using System.Threading.Tasks;
//using var playwright = await Playwright.CreateAsync();
//await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
//{
//    Headless = false,
//});
//var context = await browser.NewContextAsync();

//var page = await context.NewPageAsync();
//await page.GotoAsync("https://localhost:7243/counter");
//await page.GetByRole(AriaRole.Button, new() { Name = "Click me" }).ClickAsync();
//await page.GetByText("Current count:").ClickAsync();
//await page.GetByRole(AriaRole.Button, new() { Name = "Click me" }).ClickAsync();
//await Expect(page.GetByRole(AriaRole.Status)).ToContainTextAsync("Current count: 2");
//await page.GetByRole(AriaRole.Button, new() { Name = "Click me" }).ClickAsync();
//await Expect(page.GetByRole(AriaRole.Status)).ToContainTextAsync("Current count: 3");