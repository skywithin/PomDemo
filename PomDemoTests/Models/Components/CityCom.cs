using PomDemoTests.Models.Base;

namespace PomDemoTests.Models.Components;

public class CityCom : BaseComponentObject
{
    public string Name { get; set; } = "";
    public ILocator SelectCityButton => Page.GetByRole(AriaRole.Button, new() { Name = this.Name });


    public async Task ClickSelectCityButton()
    {
        await SelectCityButton.ClickAsync();
    }
}
