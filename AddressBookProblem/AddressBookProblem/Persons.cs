using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace AddressBookSystem
{
    public class ContactDetails
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public long PhoneNumber;
        public string Email;
        public string AddressBook;

        public ContactDetails()
        {
        }

        public ContactDetails(string addressBook, string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
            AddressBook = addressBook;
        }
        public string toString()
        {
            return "Address Book: " + AddressBook + "\n"
                                   + "" + " Details of " + FirstName + " " + LastName + " are: " + " Address: " + Address + "  City: " + City + "\n " +
                                   " State: " + State + "  Zip: " + Zip + "\n PhoneNumber: " + PhoneNumber + "\n Email: " + AddressBook;

        }
    }
}