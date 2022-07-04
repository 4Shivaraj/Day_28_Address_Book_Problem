using System;

namespace AddressBookSystem
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to Address Book Program ");
            Addressbook studentBook = new Addressbook();


            //Address book created  for student
            studentBook.AddDetails("Student", "Shivaraj", " Gowda ", " Basaveshwar nagar ", "Bangalore", "Karnataka", 560079, 8618199771, " 4shivaraj.gowda.com ");
            studentBook.AddDetails("Student", "Deepak", " Kumar ", " Kamala Nagar ", "Bangalore", "Karnataka", 560079, 880664052, " Dkumar@gmail.com ");
            studentBook.AddDetails("Student", "Priya", " Deshmukh ", " Kamakya ", "Hyderabad", "Telangana", 560056, 88060214103, " deshmukh@gmail.com ");
            studentBook.AddDetails("Student", "Sachin", " HG ", " Sagar ", "Shimoga", "Karnataka", 400517, 8875811103, " sachinhg@gmail.com ");
            studentBook.AddDetails("Student", "Sheetal", " Patel ", " Gandhi nagar ", "Ahmdabad", "Gujrat", 400017, 8806154783, " pawar@gmail.com ");
            Console.WriteLine(" Enter stored Book Name : ");
            string addressBook = Console.ReadLine();
            studentBook.AddressBook(addressBook);
            studentBook.ComputeDetails();
            studentBook.Search();
            studentBook.Count();

        }
    }
}


//UC-7
//Ability to ensure there is no Duplicate Entry of the same Person in a particular Address Book
//- Duplicate Check is done on Person Name while adding person to Address Book.
//- Use Collection Methods to Search Person by Name for Duplicate Entry
//- Override equals method to check for Duplicate
//- Use Lambda

//Welcome to Address Book Program
// Enter stored Book Name :
//Student
//Address Book: Student
// Details of Shivaraj  Gowda  are:  Address: Basaveshwar nagar   City: Bangalore
//  State: Karnataka Zip: 560079
// PhoneNumber: 8618199771
// Email: Student
//Address Book: Student
// Details of Deepak  Kumar  are:  Address: Kamala Nagar   City: Bangalore
//  State: Karnataka Zip: 560079
// PhoneNumber: 880664052
// Email: Student
//Address Book: Student
// Details of Priya  Deshmukh  are:  Address: Kamakya City: Hyderabad
//  State: Telangana Zip: 560056
// PhoneNumber: 88060214103
// Email: Student
//Address Book: Student
// Details of Sachin  HG  are:  Address: Sagar City: Shimoga
//  State: Karnataka Zip: 400517
// PhoneNumber: 8875811103
// Email: Student
//Address Book: Student
// Details of Sheetal  Patel  are:  Address: Gandhi nagar   City: Ahmdabad
//  State: Gujrat Zip: 400017
// PhoneNumber: 8806154783
// Email: Student
// Enter state
//Karnataka
// Enter city
//Bangalore
// Find Person
//Shivaraj
//Shivaraj is  in Bangalore
//City: Bangalore Address Book: Student
// Details of Shivaraj  Gowda  are:  Address: Basaveshwar nagar   City: Bangalore
//  State: Karnataka Zip: 560079
// PhoneNumber: 8618199771
// Email: Student
//State: Karnataka Address Book: Student
// Details of Shivaraj  Gowda  are:  Address: Basaveshwar nagar   City: Bangalore
//  State: Karnataka Zip: 560079
// PhoneNumber: 8618199771
// Email: Student
//1
// Enter state
//Karnataka
// No of contacts from the state: Karnataka are 3
