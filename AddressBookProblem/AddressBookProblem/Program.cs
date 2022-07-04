// See https://aka.ms/new-console-template for more information

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Problems");
            AddressBook addressBook = new AddressBook();
            addressBook.AddContact();
        }
    }
}


//UC-1
//Ability to create a Contacts in Address
//Book with first and last names, address,
//city, state, zip, phone number and
//email...
//- Program is written using IDE like IntelliJ
//- Every UC is in a separate Git Branch and then merged with main
//- Naming Convention, Indentation, etc Code Hygiene will be checked during Review
//- Git Check In Comments and Version History will be monitored


//Welcome To Address Book Problems
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