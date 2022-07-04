// See https://aka.ms/new-console-template for more information

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            AddressBookSystem addressBook = new AddressBookSystem();

            while (true)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("1. add contact   2. edit contact");
                Console.WriteLine("3. view contact 4. delete contact");
                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            addressBook.AddContact();
                            break;
                        case 2:
                            addressBook.EditContact();
                            break;
                        case 3:
                            addressBook.ViewContact();
                            break;
                        case 4:
                            addressBook.DeleteContact();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("wrong input");
                }
            }
        }
    }
   
}


//UC-4
//Ability to delete a person using person's name

//Welcome to Address Book Program
//1. add contact   2. edit contact
//3. view contact 4. delete contact
//1
//add contact
//First Name:
//Shivaraj
//Last Name:
//Gowda
//Address:
//Basaveshwarnagar
//City:
//Bangalor
//State:
//Karnataka
//Zip:
//560079
//Phone number:
//8618199771
//Email:
//4shivayash @gmail.com
//contact added

//Welcome to Address Book Program
//1. add contact   2. edit contact
//3. view contact 4. delete contact
//4
//Enter contact name:
//Shivaraj Gowda
//contact removed
//Welcome to Address Book Program
//1. add contact   2. edit contact
//3. view contact 4. delete contact
//3
//Enter full name:
//Shivaraj Gowda
//Contact doesn't exist
