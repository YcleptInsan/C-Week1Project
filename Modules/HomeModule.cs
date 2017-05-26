using Nancy;
using System.Collections.Generic;


namespace AddressBook.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=>
      {
        return View["index.cshtml"];
      };
			Get["/contact"] = _ =>
			{
				return View["contact_form.cshtml"];
			};
			Get["/newContact"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
			Post["/newContact"] = _ => {
        Category newCategory = new Category(Request.Form["new-contact"]);
        List<Category> allCategories = Category.GetAll();
        return View["index.cshtml", allCategories];
      };
			Get["/contact/{id}"]= parameters => {
			 Dictionary<string, object> model = new Dictionary<string, object>();
			 Category selectedCategory = Category.Find(parameters.id);
			 List<Contact> categoryContacts = selectedCategory.GetContacts();
			 model.Add("category", selectedCategory);
			 model.Add("tasks", categoryTasks);
			 return View["category.cshtml", model];
		 };
		}
  }
}
