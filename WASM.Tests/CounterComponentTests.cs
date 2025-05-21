namespace WASM.Tests;

public class CounterComponentTests
{
    [Fact]
    public void CounterComponent_ShouldRenderCorrectly()
    {
        var ctx = new TestContext();

        var cut = ctx.RenderComponent<CounterComponent>();

        cut.MarkupMatches("<p role=\"status\">Current count: 0</p><button class=\"btn btn-primary\">Click me</button>");
    }

    [Fact]
    public void CounterComponent_ShouldIncrementCount_WhenButtonClicked()
    {
        var ctx = new TestContext();

        var cut = ctx.RenderComponent<CounterComponent>();

        cut.MarkupMatches("<p role=\"status\">Current count: 0</p><button class=\"btn btn-primary\">Click me</button>");

        var buttonElement = cut.Find("button");

        buttonElement.Click();

        cut.MarkupMatches("<p role=\"status\">Current count: 1</p><button class=\"btn btn-primary\">Click me</button>");
    }

    //[Fact]
    //public void CounterComponent_WhenButtonClickedAndReset_ShouldRenderCorrectly()
    //{
    //    var ctx = new TestContext();

    //    var cut = ctx.RenderComponent<CounterComponent>();

    //    cut.MarkupMatches("<p role=\"status\">Current count: 0</p><button class=\"btn btn-primary\">Click me</button>");

    //    var buttonElement = cut.Find("button");

    //    buttonElement.Click();
    //    buttonElement.Click();

    //    cut.MarkupMatches("<p role=\"status\">Current count: 2</p><button class=\"btn btn-primary\">Click me</button>");
    
    //    cut.Instance.ResetCount();
    //}
}
