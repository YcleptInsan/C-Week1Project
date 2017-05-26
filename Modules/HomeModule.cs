using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=>
      {
        List<Contact> allTomogatchi = userTomogatchi.GetAll();
        return View["views.cshtml"];
      };
      Post["/tomo-name"] =_=>
      {
        userContact myTomogatchi = new UserTomogatchi(Request.Form["new-name"]);
        List<UserTomogatchi> allTomogatchi = userTomogatchi.GetAll();
        return View["yourTomo.cshtml", allTomogatchi];
      };
    }
  }
}
