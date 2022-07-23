using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Welcome to Address Book System ");
            Addressbook studentBook = new Addressbook();


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
                Console.WriteLine("6: Read address book from file");
                Console.WriteLine("7: Write address book from file");
                Console.WriteLine("8: write address book from csv file");
                Console.WriteLine("9: Read address book from csv file");
                Console.WriteLine("10: write address book from Json file");
                Console.WriteLine("11: Read address book from Json file");
                Console.WriteLine("12: Retrieve from Database");
                Console.WriteLine("13: Update contact in DB");
                Console.WriteLine("14: Get entries Added in particular DateRange");
                

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
                        studentBook.ReadAFile();
                        break;
                    case 7:
                        studentBook.SortByFirstName();
                        studentBook.WriteAFile();
                        break;
                    case 8:
                        studentBook.CsvSerialization();
                        break;
                    case 9:
                        studentBook.CsvDeSerialization();
                        break;
                    case 10:
                        studentBook.JsonSerialize();
                        break;
                    case 11:
                        studentBook.JsonDeSerialize();
                        break;
                    case 12:
                        string query = "select * from AddressBook";
                        studentBook.GetEntriesFromDB(query);
                        break;
                    case 13:
                        ContactDetails contact = new ContactDetails();
                        Console.WriteLine("Enter first name of contact");
                        contact.firstName = Console.ReadLine();
                        Console.WriteLine("Enter new City");
                        contact.city = Console.ReadLine();
                        Console.WriteLine("Enter new ZipCode");
                        contact.zip = Convert.ToInt32(Console.ReadLine());
                        studentBook.UpdateContactInDB(contact);
                        break;
                    case 14:
                        string query1 = "select * from AddressBook where Date_Added between cast('2020-02-03' as date) and getdate()";
                        studentBook.GetEntriesFromDB(query1);
                        break;
                }
            }
        }
    }
}

/*
 UC-18
Ability to Retrieve Contacts from the Database that were added in a particular period 
- Use ADO.NET for CRUD operation with DB - Introduce date_added field in the table where Contacts are mainatined.

 Welcome to Address Book System
 Enter  stored Book name :
Student
1:Search person by city or state
2: Count of the person in  city
3: Display the details
4: Display by sorted first name
5: Display by sorted City or zip
6: Read address book from file
7: Write address book from file
8: write address book from csv file
9: Read address book from csv file
10: write address book from Json file
11: Read address book from Json file
12: Retrieve from Database
13: Update contact in DB
14: Get entries Added in particular DateRange
Enter the choice want to perform the function
14
Shivaraj, Gowda, DGG, Bangaluru, CG, 560078, 9689556677, raj@gmail.com
Krisha, murthy, DGG, DGG, CG, 491445, 9644556677, krish07@gmail.com
Nikhil, Yadav, Bhilai, Bhilai, CG, 490020, 9644556677, nikhil@gmail.com
Krisha, murthy, DGG, DGG, CG, 491445, 9644556677, krish07@gmail.com
Vinay, Kumar, Nagarabhavi, Bangalore, Karnataka, 560079, 9975776600, vinay@gmail.com
*/