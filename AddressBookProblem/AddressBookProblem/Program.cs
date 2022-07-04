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
                Console.WriteLine("3. view contact");
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


//UC-3
//Ability to edit existing contact person using their name
//Use Console to edit person details

//Welcome to Address Book Program
//1. add contact   2. edit contact
//3. view contact
//1
//add contact
//First Name:
//Shivaraj
//Last Name:
//K
//Address:
//Basaveshwar Nagar
//City:
//Bangalore
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
//3. view contact
//2
//Enter full contact name
//Shivaraj K
//enter choice
//1. First Name    2. Last Name    3. Address
//4. City          5. State        6. Zip
//7. Phone number  8. Email
//2
//Enter contact field:
//Gowda
//Welcome to Address Book Program
//1. add contact   2. edit contact
//3. view contact
//3
//Enter full name:
//Shivaraj K
//wrong input
//Welcome to Address Book Program
//1. add contact   2. edit contact
//3. view contact
//3
//Enter full name:
//Shivaraj K
//wrong input
//Welcome to Address Book Program
//1. add contact   2. edit contact
//3. view contact
//3
//Enter full name:
//Shivaraj K
//First Name: Shivaraj
//Last Name:Gowda