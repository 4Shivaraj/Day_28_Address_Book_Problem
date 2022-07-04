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


//UC-5
//Ability to add multiple person to Address Book
//- Use Console to add person details one at a time
//- Use Collection Class to maintain multiple contact persons in Address Book

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
//1
///First Name:
//Deepak
//Last Name:
//R
//Address:
//Basaveshwarnagar
//City:
//Bangalore
//State:
//Karnataka
//Zip:
//560079
//Phone number:
//8745678853
//Email:
//4deepakkumr97@gmail.com
//contact added