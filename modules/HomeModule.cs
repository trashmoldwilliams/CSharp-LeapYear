using Nancy;
using LeapYearNS.Objects;
using System.Collections.Generic;

namespace LeapYearNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["header.cshtml"];
      };
    }
  }
}
