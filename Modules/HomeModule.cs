using Nancy;
using System.Collections.Generic;
using System;


namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      // Gettting a List of All Contacts
      Get["/"] =_=> {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };

      Get["/contact/form"] = _ => {
        return View["contact_form.cshtml"];

      };
      Get["/contact/form"] = _ => {
        Contact newContactInfo = new Contact(Request.Form["contact-name"],            Request.Form["contact-phone-number"], Request.Form["contact-address"]);

        return View["contact_new_info.cshtml", newContactInfo];
      };
			Post["/contact/new"] = _ => {
        Contact newContactInfo = new Contact(Request.Form["contact-name"],            Request.Form["contact-phone-number"], Request.Form["contact-address"]);
        List<Contact> allContacts = Contact.GetAll();
        allContacts.Add(newContactInfo);

        return View["contact_new_info.cshtml", newContactInfo];
      };

			Get["/contact/{id}"]= parameters => {
			 Contact selectedContact = Contact.Find(parameters.id);
			 return View["contact.cshtml", selectedContact];
		  };
		  Post["/contact/update"] = _ => {
       Contact.ClearAll();
       return View["index.cshtml"];
      };
		}
  }
}
