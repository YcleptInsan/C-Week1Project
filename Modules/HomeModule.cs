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
      Post["/contact/form"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        Contact newContactInfo = new Contact(Request.Form["contact-name"],            Request.Form["contact-phone-number"], Request.Form["contact-address"]);

        return View["contact_new_info.cshtml", newContactInfo];
      };
			Post["/contact/new/info"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        Contact newContactInfo = new Contact(Request.Form["contact-name"],            Request.Form["contact-phone-number"], Request.Form["contact-address"]);
        allContacts.Add(newContactInfo);

        return View["contact_new_info.cshtml", newContactInfo];
      };

			Get["/contact/{id}"]= parameters => {
			 Contact selectedContact = Contact.Find(parameters.id);
			 return View["contact.cshtml", selectedContact];
		  };
		  Post["/contacts/clear"] = _ => {
       Contact.ClearAll();
       return View["clear_all_contact.cshtml"];
      };
		}
  }
}
