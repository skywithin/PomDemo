namespace PomDemoTests.Models.Base;

public abstract class TestBase : IAsyncLifetime
{
    protected TestingContext Ctx = default!;

    public async Task InitializeAsync()
    {
        Ctx = new TestingContext();
    }

    public async Task DisposeAsync()
    {
        await Ctx.DisposeAsync();
        Ctx = null!;
    }
}
