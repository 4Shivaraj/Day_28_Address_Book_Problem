using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBook
    {
        //Create dictionary to store result
        Dictionary<string, string> Contactlist = new Dictionary<string, string>();
        public void AddContact()
        {
            Console.WriteLine("first Name:");
            Contactlist.Add("first Name", Console.ReadLine());

            Console.WriteLine("last Name:");
            Contactlist.Add("last Name", Console.ReadLine());

            Console.WriteLine("Address:");
            Contactlist.Add("Address", Console.ReadLine());

            Console.WriteLine("City:");
            Contactlist.Add("City", Console.ReadLine());

            Console.WriteLine("State:");
            Contactlist.Add("State", Console.ReadLine());

            Console.WriteLine("Zip:");
            Contactlist.Add("Zip", Console.ReadLine());

            Console.WriteLine("Phone number:");
            Contactlist.Add("Phone number", Console.ReadLine());

            Console.WriteLine("Email:");
            Contactlist.Add("Email", Console.ReadLine());
        }
    }
}

