using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;


namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      // Gettting a List of All Contacts
      Get["/contact"] =_=>
      {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      // Getting view to display form
      Get["/contact/form"] = _ =>
      {
        return View["contact_form.cshtml"];
      }
			Get["/contact/new"] = _ =>
			{
        Contact newContact = new Contact();
        newContact.Get(Request.Form["contact-name"], Request.Form["contact-phone-number"], Request.Form["contact-address"]);
        return View["index.cshtml", allContacts];
				return View["contact_form.cshtml"];
			};
			Post["/contact"] = _ => {
        List<Contact> allContacts = new Contact();
        allContacts.
      };
		// 	Post["/"] = _ => {
		// 		Dictionary<string, object> model = new Dictionary<string, object>();
 	// 		 	Category selectedCategory = Category.Find(parameters.id);
 	// 		 	List<Contact> categoryContacts = selectedCategory.GetContacts();
 	// 		 	model.Add("category", selectedCategory);
 	// 		 	model.Add("contacts", categoryContacts);
 	// 		 	return View["index.cshtml", model];
    //   };
		// // 	Get["/contact/{id}"]= parameters => {
		// 	 Dictionary<string, object> model = new Dictionary<string, object>();
		// 	 Category selectedCategory = Category.Find(parameters.id);
		// 	 List<Contact> categoryContacts = selectedCategory.GetContacts();
		// 	 model.Add("category", selectedCategory);
		// 	 model.Add("contacts", categoryContacts);
		// 	 return View["category.cshtml", model];
		//  };
		// Post["/contact/update"] = _ => {
    //     Dictionary<string, object> model = new Dictionary<string, object>();
    //     Category selectedCategory = Category.Find(Request.Form["category-id"]);
    //     int toDelete = Request.Form["contact-id"];
    //     selectedCategory.DeleteTask(toDelete);
    //     List<Task> categoryInforamtion = selectedCategory.GetContacts();
    //     model.Add("contacts", categoryTasks);
    //     model.Add("category", selectedCategory);
    //     return View["category.cshtml", model];
    //   };
		}
  }
}
