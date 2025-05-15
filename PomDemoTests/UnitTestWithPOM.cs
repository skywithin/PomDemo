using Microsoft.Playwright.Xunit;
using PomDemoTests.Models;

namespace PomDemoTests;

public class UnitTestWithPOM : PageTest
{
    private const string BaseUrl = "https://localhost:7243";

    [Fact]
    public async Task Counter_Increments_OnClicks()
    {
        var page = new CounterPage(Page, BaseUrl);
        
        await page.GotoAsync();

        Assert.Equal(0, await page.GetCountAsync());
        
        await page.ClickIncrementAsync();
        
        Assert.Equal(1, await page.GetCountAsync());
        
        await page.ClickIncrementAsync();

        Assert.Equal(2, await page.GetCountAsync());
    }

}

