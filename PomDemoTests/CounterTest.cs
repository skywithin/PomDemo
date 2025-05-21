namespace PomDemoTests;

public class CounterTest : BlazorPageTest
{
    private string appUrl = $"{RootUri.AbsoluteUri}counter";

    [Fact]
    public async Task Counter_Should_Increase_When_Button_Pressed()
    {
        //await Page.PauseAsync();

        await Page.GotoAsync(appUrl);

        await Page.GetByRole(AriaRole.Link, new() {  Name = "Counter" }).ClickAsync();

        await Page.GetByRole(AriaRole.Button, new() {  Name = "Click me" }).ClickAsync();

        await Expect(Page.GetByRole(AriaRole.Status)).ToHaveTextAsync("Current count: 1");
    }
}
