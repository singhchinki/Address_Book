using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book
{
    internal class Ability_To_Add
    {
        public void createContacts()
        {
            CreatContact contact = new CreatContact();
            Console.WriteLine("Enter First Name: ");
            contact.FirstName = Console.ReadLine();
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

            Groups.person.Add(contact);
        }
        public static void displayContacts()
        {
            if (Program.person.Count == 0)
            {
                Console.WriteLine("Address book is empty.");
                return;
            }
            Console.WriteLine("List of contacts:\n");
            foreach (var contact in Program.person)
            {
                Console.WriteLine("\nFirst Name: " + contact.fName + "\nLast Name: " + contact.lName + "\nAddress: " + contact.address + "\nCity: " + contact.city + "\nState: " + contact.state + "\nZip Code: " + contact.zip + "\nContact No.: " + contact.phoneNo + "\nEmail address: " + contact.email + "--\n");
            }
        }
        public static void editContacts()
        {
            Console.WriteLine("Enter Name of person to edit details: ");
            string name = Console.ReadLine();
            foreach (var contact in Program.person)
            {
                if (contact.fName.Equals(name))
                {
                    Console.WriteLine("Which field you want to edit:\n1.First Name\n2.last Name\n3.Address\n4.city\n5.state\n6.zip\n7.Phone No.\n8.Email");
                    Console.WriteLine("Enter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter First Name to update:");
                            contact.fName = Convert.ToString(Console.ReadLine());
                            break;
                    }
                }
            }
        }
    }
}

 
