using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;
using System.Text.RegularExpressions;

namespace PomDemoTests;

public class UnitTest1 : PageTest
{
    [Fact]
    public async Task HasTitle()
    {
        Console.WriteLine($"Run 'HasTitle' test");

        //await Page.GotoAsync("https://playwright.dev");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
    }

    [Fact]
    public async Task GetStartedLink()
    {
        Console.WriteLine($"Run 'GetStartedLink' test");

        //await Page.GotoAsync("https://playwright.dev");

        // Click the get started link.
        await Page
                .GetByRole(AriaRole.Link, new() { Name = "Get started" })
                .ClickAsync();

        // Expects page to have a heading with the name of Installation.
        await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Installation" }))
                .ToBeVisibleAsync();
    }

    override public async Task InitializeAsync()
    {
        Console.WriteLine("Initialize test");
        await base.InitializeAsync();
        await Page.GotoAsync("https://playwright.dev");
    }

    public override async Task DisposeAsync()
    {
        Console.WriteLine("After each test cleanup");
        await base.DisposeAsync();
    }
}
