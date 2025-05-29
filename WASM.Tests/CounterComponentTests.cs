namespace WASM.Tests;

public class CounterComponentTests : TestContext
{
    [Fact]
    public void CounterComponent_ShouldRenderCorrectly()
    {
        var cut = RenderComponent<CounterComponent>();

        cut.MarkupMatches("<p role=\"status\">Current count: 0</p><button class=\"btn btn-primary\">Click me</button>");
    }

    [Fact]
    public void CounterComponent_ShouldIncrementCount_WhenButtonClicked()
    {
        var cut = RenderComponent<CounterComponent>();

        cut.MarkupMatches("<p role=\"status\">Current count: 0</p><button class=\"btn btn-primary\">Click me</button>");

        var buttonElement = cut.Find("button");
        var status = cut.Find("p[role='status']");

        Assert.Equal("Current count: 0", status.InnerHtml);

        buttonElement.Click();

        Assert.Equal("Current count: 1", status.InnerHtml);
        cut.MarkupMatches("<p role=\"status\">Current count: 1</p><button class=\"btn btn-primary\">Click me</button>");
    }

    //[Fact]
    //public void CounterComponent_WhenButtonClickedAndReset_ShouldRenderCorrectly()
    //{
    //    var cut = RenderComponent<CounterComponent>();

    //    cut.MarkupMatches("<p role=\"status\">Current count: 0</p><button class=\"btn btn-primary\">Click me</button>");

    //    var buttonElement = cut.Find("button");

    //    buttonElement.Click();
    //    buttonElement.Click();

    //    cut.MarkupMatches("<p role=\"status\">Current count: 2</p><button class=\"btn btn-primary\">Click me</button>");
    
    //    cut.Instance.ResetCount();
    //}
}
