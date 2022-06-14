using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book
{
    internal class Person
    {
        public static List<CreatContact> person = new List<CreatContact>();
        public Dictionary<string, List<CreatContact>> group = new Dictionary<string, List<CreatContact>>();
        public Dictionary<string, List<string>> byCity = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> ByState = new Dictionary<string, List<string>>();



        public static void createContacts()
        {
            CreatContact contact = new CreatContact();
            Console.WriteLine("Enter First Name: ");
            contact.FirstName = Console.ReadLine();
            CreatContact contacts = person.FirstOrDefault(p => p.Equals(contact));
            if (contacts == null)
            {


                Console.WriteLine("Enter Last Name: ");
                contact.LastName = Console.ReadLine();
                Console.WriteLine("Enter Phone Number: ");
                contact.PhoneNo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Address: ");
                contact.Address = Console.ReadLine();
                Console.WriteLine("Enter City: ");
                contact.City = Console.ReadLine();
                Console.WriteLine("Enter Zip: ");
                contact.Zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter State: ");
                contact.State = Console.ReadLine();
                Console.WriteLine("Enter Email: ");
                contact.Email = Console.ReadLine();

                person.Add(contact);

            }
            else
                Console.WriteLine("Contact already exist");
        }

        public void displayContacts()
        {
            if (person.Count == 0)
            {
                Console.WriteLine("Address book is empty.");
                return;
            }
            Console.WriteLine("1.Total Contacts\n2.Group");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
              case 1:
                Console.WriteLine("List of contacts:\n");
              foreach (string key in group.Keys)
              {
                List<CreatContact> contacts = group[key];
                foreach (var contact in contacts)
                {
                    Console.WriteLine("\nFirst Name: " + contact.FirstName + "\nLast Name: " + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip Code: " + contact.Zip + "\nContact No.: " + contact.PhoneNo + "\nEmail address: " + contact.Email + "--\n");
                }
              }
                    break;
                case 2:
                    foreach (string key in group.Keys)
                    {
                        Console.WriteLine(key);
                    }
                    Console.WriteLine("Enter group you want to display.");
                    string gName = Console.ReadLine();
                    List<CreatContact> list = group[gName];

                    foreach (var contact in list)
                        Console.WriteLine("\nFirst Name: " + contact.FirstName + "\nLast Name: " + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip Code: " + contact.Zip + "\nContact No.: " + contact.PhoneNo + "\nEmail address: " + contact.Email + "---\n");
                    break;


            }
        }

            public static void editContacts()
            {
                Console.WriteLine("Enter Name of person to edit details: ");
                string name = Console.ReadLine();
                foreach (var contact in Program.person)
                {
                    if (contact.FirstName.Equals(name))
                    {
                        Console.WriteLine("Which field you want to edit:\n1.First Name\n2.last Name\n3.Address\n4.city\n5.state\n6.zip\n7.Phone No.\n8.Email");
                        Console.WriteLine("Enter your choice:");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter First Name to update:");
                                contact.FirstName = Convert.ToString(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Enter Last Name to update:");
                                contact.LastName = Convert.ToString(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter Address to update:");
                                contact.Address = Convert.ToString(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("Enter City to update:");
                                contact.City = Convert.ToString(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter State to update:");
                                contact.State = Convert.ToString(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Enter Zip code to update:");
                                contact.Zip = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 7:
                                Console.WriteLine("Enter Phone to update:");
                                contact.PhoneNo = Convert.ToDouble(Console.ReadLine());
                                break;
                            case 8:
                                Console.WriteLine("Enter Email to update:");
                                contact.Email = Convert.ToString(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Invalid option:");
                                break;
                        }
                    }
                }
            }

            public static void removeContact()
            {
                Console.WriteLine("Enter Name of person to delete details: ");

                string name = Console.ReadLine();
                foreach (var contact in Program.person.ToList())
                {
                    if (contact.FirstName.Equals(name))
                    {
                        person.Remove(contact);
                    }
                }
            }
            public  void addMultiContacts()
            {
                Console.WriteLine("How many contacts you want to add:");
                int n = Convert.ToInt32(Console.ReadLine());
                person = new List<CreatContact>(); //UC-7 No Duplicate Contact
                while (n > 0)
                {
                    createContacts();
                    n--;
                }
            }
            public void addMultiAddressBooks()
            { 
                Console.WriteLine("How many address books you want to add: ");
                int noOfBooks = Convert.ToInt32(Console.ReadLine());
                while (noOfBooks > 0)
                {
                    Console.WriteLine("Enter group name:");
                    string gName = Console.ReadLine();
                    addMultiContacts();
                    group.Add(gName, person.ToList());
                    noOfBooks--;

                }
            }
            public void searchByCityOrState()
            {
                Console.WriteLine("Enter City or state to search contacts:");
                string value = Console.ReadLine();
                foreach (var Contacts in group.Values)
                {
                    List<CreatContact> city = Contacts.FindAll(p => p.City.ToLower() == value.ToLower());
                    List<CreatContact> state = Contacts.FindAll(p => p.State.ToLower() == value.ToLower());
                    if (city.Count != 0)
                    {
                        Console.WriteLine("All contacts from city {0} are:", value);
                        foreach (var contact in city)
                        {
                            Console.WriteLine("Name:{0} {1}", contact.FirstName, contact.LastName);
                        }
                    }
                    else if (state.Count != 0)
                    {
                        Console.WriteLine("All contacts from state {0} are:", value);
                        foreach (var contact in state)
                        {
                            Console.WriteLine("Name:{0} {1}", contact.FirstName, contact.LastName);
                        }
                    }
                    else
                        Console.WriteLine("No contact details availbale for given city/State.");
                }
            }
        public void displayByCityOrState()
        {
            foreach (var key in group.Keys)
            {
                foreach (var item in group[key])
                {

                    if (byCity.ContainsKey(item.City))
                        byCity[item.City].Add(item.FirstName + " " + item.LastName);
                    else
                        byCity.Add(item.City, new List<string>() { item.FirstName + " " + item.LastName });
                    if (ByState.ContainsKey(item.State))
                        ByState[item.State].Add(item.FirstName + " " + item.LastName);
                    else
                        ByState.Add(item.State, new List<string>() { item.FirstName + " " + item.LastName });
                }
            }
            Console.WriteLine("Contacts by city:");
            foreach (var key in byCity.Keys)
            {
                Console.WriteLine("Contacts from city:" + key);
                byCity[key].ForEach(x => Console.WriteLine(x));

            }
            Console.WriteLine("Contacts by state:");
            foreach (var key in ByState.Keys)
            {
                Console.WriteLine("Contacts from state: " + key);
                ByState[key].ForEach(x => Console.WriteLine(x));
            }
        }
        public void getCount()
        {
            foreach (var key in group.Keys)
            {
                foreach (var item in group[key])
                {

                    if (byCity.ContainsKey(item.City))
                        byCity[item.City].Add(item.FirstName + " " + item.LastName);
                    else
                        byCity.Add(item.City, new List<string>() { item.FirstName + " " + item.LastName });
                    if (ByState.ContainsKey(item.State))
                        ByState[item.State].Add(item.FirstName + " " + item.LastName);
                    else
                        ByState.Add(item.State, new List<string>() { item.FirstName + " " + item.LastName });
                }
            }
            Console.WriteLine("No. of contacts by city.");
            foreach (var key in byCity.Keys)
            {
                Func<int, int> count = x =>
                {
                    foreach (var value in byCity[key])
                        x += 1;
                    return x;
                };
                Console.WriteLine("No. of contacts in city " + key + " are " + count(0));
            }
            Console.WriteLine("No. of contacts by state.");
            foreach (var key in ByState.Keys)
            {
                Func<int, int> count = x =>
                {
                    foreach (var value in ByState[key])
                        x += 1;
                    return x;
                };
                Console.WriteLine("No. of contacts in state " + key + " are " + count(0));
            }

        }
    }
}




