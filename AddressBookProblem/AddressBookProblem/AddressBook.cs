using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AddressBookSystem
{
    public class Addressbook
    {
        List<ContactDetails> contactDetailsList;
        private Dictionary<string, ContactDetails> contactDetailsMap;
        private Dictionary<string, Dictionary<string, ContactDetails>> multipleAddressBookMap;
        private List<ContactDetails> sortedBookList;

        public Addressbook()
        {
            contactDetailsList = new List<ContactDetails>();
            contactDetailsMap = new Dictionary<string, ContactDetails>();
            multipleAddressBookMap = new Dictionary<string, Dictionary<string, ContactDetails>>();
            sortedBookList = new List<ContactDetails>();

        }
        public void ContactlistEntry()
        {
            ContactDetails personEntered = new ContactDetails();
            Console.WriteLine("Enter First name");
            string firstName = Console.ReadLine();
            personEntered.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last name");
            string lastName = Console.ReadLine();
            personEntered.LastName = Console.ReadLine();

            if (contactDetailsList.Find(i => personEntered.Equals(i)) != null)
            {
                Console.WriteLine("Person already Exists, enter new person!");
                return;
            }
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            personEntered.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            personEntered.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            personEntered.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            int zip = Convert.ToInt32(Console.ReadLine());
            string zipString = zip.ToString();
            personEntered.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phoneNumber");
            long phoneNumber = Convert.ToInt32(Console.ReadLine());
            string phoneNumberString = phoneNumber.ToString();
            personEntered.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            personEntered.Email = Console.ReadLine();
            contactDetailsList.Add(personEntered);
        }
        /// <summary>
        /// UC12: Sorted person in alphabatical order as per the city or zip or state
        /// </summary>
        public void SortByCityOrStateOrZip()
        {
            List<ContactDetails> sortedList;
            Console.WriteLine(" Sort the contacts by City or State or Zip ");
            Console.WriteLine("1: Entered for sorting list by City ");
            Console.WriteLine("2: Entered for sorting list by State");
            Console.WriteLine("3: Entered for sorting list by zip");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    sortedList = contactDetailsList.OrderBy(x => x.City).ToList();
                    foreach (ContactDetails book in sortedList)
                    {
                        Console.WriteLine(book.toString());
                    }
                    break;
                case 2:
                    sortedList = contactDetailsList.OrderBy(x => x.State).ToList();
                    foreach (ContactDetails book in sortedList)
                    {
                        Console.WriteLine(book.toString());
                    }
                    break;
                case 3:
                    sortedList = contactDetailsList.OrderBy(x => x.Zip).ToList();
                    foreach (ContactDetails book in sortedList)
                    {
                        Console.WriteLine(book.toString());
                    }
                    break;
            }

        }
        public List<ContactDetails> AddDetails(string addressBook, string firstName, string LastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            ContactDetails contactDetails = new ContactDetails(addressBook, firstName, LastName, address, city, state, zip, phoneNumber, email);
            contactDetailsList.Add(contactDetails);

            return contactDetailsList;

        }
        /// <summary>
        /// UC11: Sort the contactlist in alphabetical order of first name
        /// </summary>
        public void SortByFirstName()
        {
            Console.WriteLine(" Sort the contacts alphabetically ");
            sortedBookList = contactDetailsList.OrderBy(x => x.FirstName).ToList();
            foreach (ContactDetails book in sortedBookList)
            {
                Console.WriteLine(book.toString());
            }

        }

        // Create Nested Dictionary
        public void AddressBook(string addressBook)
        {
            multipleAddressBookMap.Add(addressBook, contactDetailsMap);
        }

        /// <summary>
        /// UC8: Ability to search person from the contactlist
        /// UC9: Ability to view person from the contactlist
        /// </summary>
        public Dictionary<string, ContactDetails> Search()
        {
            Console.WriteLine(" Enter state ");
            string state = Console.ReadLine();
            var stateCheck = contactDetailsList.FindAll(x => x.State == state);
            Console.WriteLine(" Enter city ");
            string city = Console.ReadLine();
            var cityCheck = stateCheck.FindAll(x => x.City == city);
            Console.WriteLine(" Find Person ");
            string firstName = Console.ReadLine();
            var person = cityCheck.Where(x => x.FirstName == firstName).FirstOrDefault(); //Returns the First Element 
            if (person != null)
            {
                Console.WriteLine(firstName + " is  in " + city);
            }
            else
            {
                Console.WriteLine(firstName + " is not  in " + city);
            }
            Dictionary<string, ContactDetails> detailCity = new Dictionary<string, ContactDetails>();
            Dictionary<string, ContactDetails> detailState = new Dictionary<string, ContactDetails>();
            detailCity.Add(city, person);
            detailState.Add(state, person);
            foreach (KeyValuePair<string, ContactDetails> i in detailCity)
            {
                Console.WriteLine("City: {0}  {1}", i.Key, i.Value.toString());
            }

            foreach (KeyValuePair<string, ContactDetails> i in detailState)
            {
                Console.WriteLine("State: {0}  {1}", i.Key, i.Value.toString());
            }

            Console.WriteLine(detailCity.Count());
            return detailCity;
        }
        /// <summary>
        /// UC10: Ability to count the person from the same state
        /// </summary>
        public void Count()
        {
            Console.WriteLine(" Enter state ");
            string state = Console.ReadLine();
            var stateCheck = contactDetailsList.FindAll(x => x.State == state);
            Console.WriteLine(" No of contacts from the state: " + state + " are " + stateCheck.Count);
        }
        public void ComputeDetails()
        {
            foreach (ContactDetails book in contactDetailsList)
            {
                Console.WriteLine(book.toString());
            }
        }
        /// <summary>
        /// UC13:Ability to write file using file I/O
        /// </summary>
        public void WriteAFile()
        {
            string InputFile = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_9\NewAddressBook\AddressBookProblem\AddContactDetails.txt";
            using (StreamWriter write = File.AppendText(InputFile))
            {
                write.WriteLine("This table contains student informaton in sorted manner");
                foreach (ContactDetails printInText in sortedBookList)
                {
                    write.WriteLine(printInText.toString());
                }
                write.Close();
                Console.WriteLine(File.ReadAllText(InputFile));
            }

        }

        /// <summary>
        /// UC13:Ability to read file using file I/O
        /// </summary>
        public void ReadAFile()
        {
            string InputFile = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_9\NewAddressBook\AddressBookProblem\AddContactDetails.txt";
            using (StreamReader read = File.OpenText(InputFile))
            {
                string s = " ";
                while ((s = read.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                read.Close();
            }
        }
    }
}