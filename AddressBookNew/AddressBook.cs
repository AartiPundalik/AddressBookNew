using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookNew
{
    public class AddressBook
    {
        Contact contact = new Contact();

        public void CreateContact()
        {
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Email = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.PhoneNumber = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.zip = Console.ReadLine();

        }
        public void Display()
        {
            Console.WriteLine("Contact Details" + "\n" + "First Name" + "contact.FirstName" + "\n" + "LastName" + "contact.LastName" + "\n" + "Email" + "contact.Email" + "\n" + "city" + "contact.City" + "\n" + "PhoneNumber" + "contact.PhoneNumber" + "\n" + "Address" + "Address" + "\n" + "zip" + "zip");
        }

    }

}