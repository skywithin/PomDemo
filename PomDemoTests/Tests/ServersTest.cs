using PomDemoTests.Models.Base;

namespace PomDemoTests.Tests;

public class ServersTest : TestBase
{
    [Fact]
    public async Task Test1()
    {
        await Ctx.Page.PauseAsync();

        var serversPage = await Ctx.RouteServers();
        await serversPage.CityList.TorontoCity.ClickSelectCityButton();
        await serversPage.CityList.MontrealCity.ClickSelectCityButton();

        //var createDocketPage = await Ctx.RouteSalesDocketCreate();
        //var createDocketPage = Ctx.GetCurrentPage<SalesDocketCreateCom>();





        //await createDocketPage.SalesDocketTypePicker.SelectOption("Sawlog Docket");
        //await createDocketPage.SalesDocketTypePicker.SelectOption("Cypress Load Docket");

        //await createDocketPage.MeasureDatePicker.FillDate(DateTime.Now);
        //await createDocketPage.MeasureDatePicker.SelectToday();
        //await createDocketPage.SalesPermitDropDown.SelectOption("10000");
        //await createDocketPage.SaleUnitDropDown.SelectOption("123");

        //await createDocketPage.SalesDocketHeader.ClickSaveButton();

        //await Ctx.Page.PauseAsync();
        //await createDocketPage.SelectDocketType("xxx");
    }
}
