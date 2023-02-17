using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookNew
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome TO Address Book Problem");
            AddressBook addressbook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select 1: For Creating Contact\n" +
                    "Select 2:Edit Existing Contact\n" +
                    "Select 3:To Display\n" +
                    "Select 4: Delete Contact\n" +
                     "Select 5:To stop\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbook.CreateContact();
                        addressbook.Display();
                        Console.ReadLine();

                        break;
                    case 2:
                        string name = Console.ReadLine();
                        addressbook.EditContact(name);
                        addressbook.Display(); Console.ReadLine();
                        
                        break;
                    case 3:
                        Console.WriteLine("Display Contact Details");
                        addressbook.Display();
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Delete Contact Details");
                        addressbook.DeleteContact();
                        Console.ReadLine();
                        break;
                    case 5:
                        flag = false;
                        break;


                }
            }
        }
    }
}