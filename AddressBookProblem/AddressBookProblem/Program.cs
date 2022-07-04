using System;

namespace AddressBookSystem
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to Address Book Program ");
            Addressbook studentBook = new Addressbook();
            Addressbook Newaddressbook = new Addressbook();


            //Address book created  for student
            studentBook.AddDetails("Student", "Shivaraj", " Gowda ", " Basaveshwar nagar ", "Bangalore", "Karnataka", 560079, 8618199771, " 4shivaraj.gowda.com ");
            studentBook.AddDetails("Student", "Deepak", " Kumar ", " Kamala Nagar ", "Bangalore", "Karnataka", 560079, 880664052, " Dkumar@gmail.com ");
            studentBook.AddDetails("Student", "Priya", " Deshmukh ", " Kamakya ", "Hyderabad", "Telangana", 560056, 88060214103, " deshmukh@gmail.com ");
            studentBook.AddDetails("Student", "Sachin", " HG ", " Sagar ", "Shimoga", "Karnataka", 400517, 8875811103, " sachinhg@gmail.com ");
            studentBook.AddDetails("Student", "Sheetal", " Patel ", " Gandhi nagar ", "Ahmdabad", "Gujrat", 400017, 8806154783, " pawar@gmail.com ");
            
            Console.WriteLine(" Enter  stored Book name : ");
            string addressBook = Console.ReadLine();
            if (addressBook == "Student")
            {
                studentBook.AddressBook(addressBook);


                //Giving option to perform
                Console.WriteLine("1:Search person by city or state");
                Console.WriteLine("2: Count of the person in  city");
                Console.WriteLine("3: Display the details");
                Console.WriteLine("4: Display by sorted first name");
                Console.WriteLine("5: Display by sorted City or zip ");
                Console.WriteLine("6: Write address book from file");
                Console.WriteLine("7: Read address book from file");
                Console.WriteLine("Enter the choice want to perform the function");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        studentBook.Search();
                        break;
                    case 2:
                        studentBook.Count();
                        break;
                    case 3:
                        studentBook.ComputeDetails();
                        break;
                    case 4:
                        studentBook.SortByFirstName();
                        break;
                    case 5:
                        studentBook.SortByCityOrStateOrZip();
                        break;
                    case 6:
                        studentBook.SortByFirstName();
                        studentBook.WriteAFile();
                        break;
                    case 7:
                        studentBook.ReadAFile();
                        break;

                }
            }

        }
    }
}


///UC-13
//Ability to Read or Write the Address Book with Persons Contact into a File using File IO
//- Using C# File IO

//WRITE
//Welcome to Address Book Program
// Enter  stored Book name :
//Student
//1:Search person by city or state
//2: Count of the person in  city
//3: Display the details
//4: Display by sorted first name
//5: Display by sorted City or zip
//6: Write address book from file
//7: Read address book from file


//Enter the choice want to perform the function
//6
// Sort the contacts alphabetically
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
//Address Book: Student
// Details of Shivaraj  Gowda  are:  Address: Basaveshwar nagar   City: Bangalore
//  State: Karnataka Zip: 560079
// PhoneNumber: 8618199771
// Email: Student
//This table contains student informaton in sorted manner
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
//Address Book: Student
// Details of Shivaraj  Gowda  are:  Address: Basaveshwar nagar   City: Bangalore
//  State: Karnataka Zip: 560079
// PhoneNumber: 8618199771

//---------------------------------------------------------------------------------//

//READ
//Enter stored Book name :
//Student
//1:Search person by city or state
//2: Count of the person in  city
//3: Display the details
//4: Display by sorted first name
//5: Display by sorted City or zip
//6: Write address book from file
//7: Read address book from file
//7
//This table contains student informaton in sorted manner
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
//Address Book: Student
// Details of Shivaraj  Gowda  are:  Address: Basaveshwar nagar   City: Bangalore
//  State: Karnataka Zip: 560079
// PhoneNumber: 8618199771
// Email: Student

//---------------------------------------------------------------------------------//