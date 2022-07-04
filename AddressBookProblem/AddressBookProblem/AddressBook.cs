using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class AddressBookSystem
    {
        //Generated dictionary for storing
        Dictionary<string, string> Contactlist;
        Dictionary<string, Dictionary<string, string>> AddressBook = new Dictionary<string, Dictionary<string, string>>();
        Dictionary<String, Dictionary<String, Dictionary<String, String>>> AddressBookCollection = new Dictionary<string, Dictionary<String, Dictionary<String, String>>>();
        String CurrentAddressBookName = "default";
        public void AddContact()
        {
            //Adding contact to the list
            Console.WriteLine("add contact");
            Contactlist = new Dictionary<string, string>();

            Console.WriteLine("First Name:");
            Contactlist.Add("First Name", Console.ReadLine());

            Console.WriteLine("Last Name:");
            Contactlist.Add("Last Name", Console.ReadLine());

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
            Contactlist.TryGetValue("First Name", out string FirstName);
            Contactlist.TryGetValue("Last Name", out string LastName);
            AddressBook.Add(FirstName + " " + LastName, Contactlist);
            Console.WriteLine("contact added\n");
        }
        public void ViewContact()
        {
            //View the contact
            Console.WriteLine("Enter full name:");
            String ContactName = Console.ReadLine();
            if (AddressBook.ContainsKey(ContactName))
            {
                Contactlist = new Dictionary<string, string>();
                AddressBook.TryGetValue(ContactName, out Contactlist);
                Console.WriteLine("First Name: " + Contactlist["First Name"]);

                Console.WriteLine("Last Name:" + Contactlist["Last Name"]);

                Console.WriteLine("Address:" + Contactlist["Address"]);

                Console.WriteLine("City:" + Contactlist["City"]);

                Console.WriteLine("State:" + Contactlist["State"]);

                Console.WriteLine("Zip:" + Contactlist["Zip"]);

                Console.WriteLine("Phone number:" + Contactlist["Phone number"]);

                Console.WriteLine("Email:" + Contactlist["Email"]);
            }
            else
                Console.WriteLine("Contact doesn't exist");
        }
        public void EditContact()
        {
            //Edit information
            Console.WriteLine("Enter full contact name");
            String ContactName = Console.ReadLine();

            if (AddressBook.ContainsKey(ContactName))
            {
                Console.WriteLine("enter choice");
                Console.WriteLine("1. First Name    2. Last Name    3. Address ");
                Console.WriteLine("4. City          5. State        6. Zip");
                Console.WriteLine("7. Phone number  8. Email");

                int Choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter contact field:");
                String Cotanctinfo = Console.ReadLine();

                switch (Choice)
                {
                    case 1:
                        AddressBook[ContactName]["First Name"] = Cotanctinfo;
                        break;
                    case 2:
                        AddressBook[ContactName]["Last Name"] = Cotanctinfo;
                        break;
                    case 3:
                        AddressBook[ContactName]["Address"] = Cotanctinfo;
                        break;
                    case 4:
                        AddressBook[ContactName]["City"] = Cotanctinfo;
                        break;
                    case 5:
                        AddressBook[ContactName]["State"] = Cotanctinfo;
                        break;
                    case 6:
                        AddressBook[ContactName]["Zip"] = Cotanctinfo;
                        break;
                    case 7:
                        AddressBook[ContactName]["Phone number"] = Cotanctinfo;
                        break;
                    case 8:
                        AddressBook[ContactName]["Email"] = Cotanctinfo;
                        break;

                }
            }
            else
                Console.WriteLine("contact doesn't exist");

        }
        public void DeleteContact()
        {
            //Delete contact
            Console.WriteLine("Enter contact name:");
            String ContactName = Console.ReadLine();
            if (AddressBook.ContainsKey(ContactName))
            {
                AddressBook.Remove(ContactName);
                Console.WriteLine("contact removed");
            }
            else
                Console.WriteLine("contact doesn't exist");
        }
        public void CreateAddressBook()
        {
            AddressBook = new Dictionary<string, Dictionary<String, String>>();
            Console.WriteLine("Enter address book name:");
            string AddressBookName = Console.ReadLine();
            if (AddressBookCollection.ContainsKey(AddressBookName))
                Console.WriteLine("Address book already exist");
            else
            {
                AddressBookCollection.Add(AddressBookName, AddressBook);
                CurrentAddressBookName = AddressBookName;
                Console.WriteLine("Address book created");
            }
        }
        public void ChangeAddressBook()
        {
            Console.WriteLine("Enter address book name:");
            String AddressBookName = Console.ReadLine();
            if (AddressBookCollection.ContainsKey(AddressBookName))
            {
                CurrentAddressBookName = AddressBookName;
                Console.WriteLine("address book changed");
            }
            else
                Console.WriteLine("address book doesn't exist");
        }
    }
}






