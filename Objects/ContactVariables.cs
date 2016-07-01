using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _address;
    private int _phoneNumber;

    private static List<Contact> _instances = new List <Contact> {};

    public Contact (string name, string address, int phoneNumber)
    {
      _name = name;
      _address = address;
      _phoneNumber = phoneNumber;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public int GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(int newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
  }
}
