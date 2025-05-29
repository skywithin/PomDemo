using PomDemoTests.Models.Base;
using PomDemoTests.Models.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomDemoTests.Models.Pages;

public class ServersCom : BaseComponentObject
{
    public CityListCom CityList => new CityListCom() { Page = base.Page };
}
