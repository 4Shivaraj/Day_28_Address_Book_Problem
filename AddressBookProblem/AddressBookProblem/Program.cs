// See https://aka.ms/new-console-template for more information

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            while (true)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("1. Create contact ");
                try
                {
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            addressBook.AddContact();
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


//UC-2
//Ability to add a new Contact to Address Book - Use Console to add person details from AddressBookMain class
//-Use Object Oriented Concepts to manage relationship between AddressBook and Contact Person

//Welcome to Address Book Program
//1. Create contact
//1
//first Name:
//Shivaraj
//last Name:
//Gowda
//Address:
//Basaveshwarnagar
//City:
//Bangalore
//State:
//Karnataka
//Zip:
//560079
//Phone number:
//8618199771
//Email:
//4shivaraj.gowda @gmail.com