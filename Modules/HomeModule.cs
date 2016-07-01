using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModuel
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        list<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["/contactForm"] = _ => {
        return View ["addContact.cshtml"];
      };
      Post["/addContact"] = _ => {
        Contact newContact = new Contact(Request.Form["name"],Request.Form["address"],Request.Form["phoneNumber"]);
        List<Contact> allContacts = Contact.GetAll();
        return View ["index.cshtml", allContacts];
      };
    }
  }
}
