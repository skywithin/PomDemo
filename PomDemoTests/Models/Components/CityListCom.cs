using PomDemoTests.Models.Base;

namespace PomDemoTests.Models.Components;

public class CityListCom : BaseComponentObject
{
    public CityCom TorontoCity => new CityCom() { Page = base.Page, Name = "Toronto" };
    public CityCom MontrealCity => new CityCom() { Page = base.Page, Name = "Montreal" };
    public CityCom OttawaCity => new CityCom() { Page = base.Page, Name = "Ottawa" };
    public CityCom CalgaryCity => new CityCom() { Page = base.Page, Name = "Calgary" };
    public CityCom HalifaxCity => new CityCom() { Page = base.Page, Name = "Halifax" };

    public SearchServersCom SearchServers => new SearchServersCom() { Page = base.Page };
}
