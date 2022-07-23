
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CsvHelper;
using System.Globalization;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;

namespace AddressBookSystem
{
    class Addressbook
    {

        List<ContactDetails> contactDetailsList;
        private Dictionary<string, ContactDetails> contactDetailsMap;
        private Dictionary<string, Dictionary<string, ContactDetails>> multipleAddressBookMap;
        private List<ContactDetails> sortedBookList;
        public static string connectionstring = @"Data Source = (localdb)\ProjectModels;Initial Catalog = AddressBook_serviceDB;Integrated Security=True;";
        SqlConnection connection = null;

        public Addressbook()
        {
            contactDetailsList = new List<ContactDetails>();
            contactDetailsMap = new Dictionary<string, ContactDetails>();
            multipleAddressBookMap = new Dictionary<string, Dictionary<string, ContactDetails>>();
            sortedBookList = new List<ContactDetails>();

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
                    sortedList = contactDetailsList.OrderBy(x => x.city).ToList();
                    foreach (ContactDetails book in sortedList)
                    {
                        Console.WriteLine(book.ToString());
                    }
                    break;
                case 2:
                    sortedList = contactDetailsList.OrderBy(x => x.state).ToList();
                    foreach (ContactDetails book in sortedList)
                    {
                        Console.WriteLine(book.ToString());
                    }
                    break;
                case 3:
                    sortedList = contactDetailsList.OrderBy(x => x.zip).ToList();
                    foreach (ContactDetails book in sortedList)
                    {
                        Console.WriteLine(book.ToString());
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
        public List<ContactDetails> SortByFirstName()
        {
            Console.WriteLine(" Sort the contacts alphabetically ");
            sortedBookList = contactDetailsList.OrderBy(x => x.firstName).ToList();
            foreach (ContactDetails book in sortedBookList)
            {
                Console.WriteLine(book.ToString());
            }
            return sortedBookList;

        }


        public void AddressBook(string addressBook)
        {
            multipleAddressBookMap.Add(addressBook, contactDetailsMap);
        }



        /// <summary>
        /// UC8: Ability to search person from the contactlist
        /// UC9: Ability to view person from the contactlist
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, ContactDetails> Search()
        {
            Console.WriteLine(" Enter state ");
            string state = Console.ReadLine();
            var stateCheck = contactDetailsList.FindAll(x => x.state == state);
            Console.WriteLine(" Enter city ");
            string city = Console.ReadLine();
            var cityCheck = stateCheck.FindAll(x => x.city == city);
            Console.WriteLine(" Find Person ");
            string firstName = Console.ReadLine();
            var person = cityCheck.Where(x => x.firstName == firstName).FirstOrDefault();
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
                Console.WriteLine("City: {0}  {1}", i.Key, i.Value.ToString());
            }

            foreach (KeyValuePair<string, ContactDetails> i in detailState)
            {
                Console.WriteLine("State: {0}  {1}", i.Key, i.Value.ToString());
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
            var stateCheck = contactDetailsList.FindAll(x => x.state == state);
            Console.WriteLine(" No of contacts from the state: " + state + " are " + stateCheck.Count);
        }
        public void ComputeDetails()
        {
            foreach (ContactDetails book in contactDetailsList)
            {
                Console.WriteLine(book.ToString());
            }
        }
        /// <summary>
        /// UC13:Ability to read file using file I/O
        /// </summary>
        public void ReadAFile()
        {
            string InputFile = @"C:\Users\User\source\repos\File IO\AddressBookDay20\AddressBookDay20\AddressBookDay20\bin\Debug\netcoreapp3.1\AddressBookDay20.txt";
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
                    write.WriteLine(printInText.ToString());
                }
                write.Close();
                Console.WriteLine(File.ReadAllText(InputFile));
            }


        }
        /// <summary>
        /// UC14: Ability to read and write the csv file
        /// </summary>
        public void CsvSerialization()
        {

            string CsvFilePath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_9\NewAddressBook\AddressBookProblem\Files\FileData.csv";

            // writing csv file
            using (var writer = new StreamWriter(CsvFilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                List<ContactDetails> sortedlist = SortByFirstName();
                csvExport.WriteRecords(sortedlist);
            }
        }
        public void CsvDeSerialization()
        {
            string CsvFilePath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_9\NewAddressBook\AddressBookProblem\Files\FileData.csv";

            //reading csv file
            using (TextReader reader = new StreamReader(CsvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<ContactDetails>().ToList();
                Console.WriteLine("Read data successfully from MultipleAddressBook.csv, here are codes ");

                foreach (ContactDetails contactDetails in records)
                {
                    Console.WriteLine("\t" + contactDetails.firstName);
                }
            }
        }
        /// <summary>
        /// UC15: Ability to read and write JSON file
        /// </summary>
        public void JsonSerialize()
        {

            string JsonFilePath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_9\NewAddressBook\AddressBookProblem\Files\FileData.json";

            string result = JsonConvert.SerializeObject(contactDetailsList);

            File.WriteAllText(JsonFilePath, result);
        }
            
        public void JsonDeSerialize()
        {
            string JsonFilePath = @"C:\Users\4shiv\OneDrive\Desktop\Fellowship\Assignments\Assignment_Day_9\NewAddressBook\AddressBookProblem\Files\FileData.json";
            if (File.Exists(JsonFilePath))
            {
                string Jsondata = File.ReadAllText(JsonFilePath);
                List<ContactDetails> result = JsonConvert.DeserializeObject<List<ContactDetails>>(Jsondata);
                if(result.Count != 0)
                {
                    foreach (ContactDetails contactDetails in result)
                    {
                        Console.WriteLine(contactDetails.toString());
                    }
                }
            }
        }
        //UC 16 - Method to retrieve entries from DB 
        public void GetEntriesFromDB(string query)
        {
            try
            {
                DataSet dataSet = new DataSet();
                using (connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataSet);
                    foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    {
                        Console.WriteLine(dataRow["FirstName"] + ", " + dataRow["LastName"] + ", " + dataRow["Address"] + ", " + dataRow["City"] + ", " + dataRow["State"] + ", " + dataRow["Zip"] + ", " + dataRow["PhoneNumber"] + ", " + dataRow["Email"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        //Method To Update Contact details on DB
        public ContactDetails UpdateContactInDB(ContactDetails obj)
        {
            try
            {
                connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand("spUpdateContacts", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@FirstName", obj.firstName);
                command.Parameters.AddWithValue("@City", obj.city);
                command.Parameters.AddWithValue("@Zip", obj.zip);

                connection.Open();
                var result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    Console.WriteLine("Contact details updated successfully");
                    return obj;
                }
                else
                {
                    Console.WriteLine("Failed to update Contact details");
                    return default;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default;
            }
            finally
            {
                connection.Close();
            }
        }
        public void GetCityCountDB(string query)
        {
            try
            {
                DataSet dataSet = new DataSet();
                using (connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataSet);
                    foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    {
                        Console.WriteLine(dataRow["City"] + ", " + dataRow["CityCount"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void GetStateCountDB(string query)
        {
            try
            {
                DataSet dataSet = new DataSet();
                using (connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataSet);
                    foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    {
                        Console.WriteLine(dataRow["State"] + ", " + dataRow["StateCount"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

