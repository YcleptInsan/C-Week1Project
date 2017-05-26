using Nancy;
using System.Collections.Generic;
using CarDealership.Objects;

namespace Tomogatchi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=>
      {
        List<UserTomogatchi> allTomogatchi = userTomogatchi.GetAll();
        return View["views.cshtml"];
      };
      Post["/tomo-name"] =_=>
      {
        userTomogatchi myTomogatchi = new UserTomogatchi(Request.Form["new-name"]);
        List<UserTomogatchi> allTomogatchi = userTomogatchi.GetAll();
        return View["yourTomo.cshtml", allTomogatchi];
      };
    }
  }
}
