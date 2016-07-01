using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["/addContact"] = _ => {
        return View ["add_contact.cshtml"];
      };
      Post["/addContact"] = _ => {
        Contact newContact = new Contact(Request.Form["name"],Request.Form["address"],Request.Form["phoneNumber"]);
        // List<Contact> allContacts = Contact.GetAll();
        return View["contact_created.cshtml", newContact];
      };
    }
  }
}
