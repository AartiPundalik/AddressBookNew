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
            
            AddressBook addressBook = new AddressBook();
            addressBook.CreateContact();
            addressBook.Display();
            Console.ReadLine();
        }
    }
}
