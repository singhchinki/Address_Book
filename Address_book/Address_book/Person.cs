﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book
{
    internal class Person
    {
        public static void createContacts()
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

            Program.person.Add(contact);
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
                Console.WriteLine("\nFirst Name: " + contact.FirstName + "\nLast Name: " + contact.LastName + "\nAddress: " + contact.Address + "\nCity: " + contact.City + "\nState: " + contact.State + "\nZip Code: " + contact.Zip + "\nContact No.: " + contact.PhoneNo + "\nEmail address: " + contact.Email + "--\n");
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
                    Program.person.Remove(contact);
                }
            }
        }
        public static void addMultiContacts()
        {
            Console.WriteLine("How many contacts you want to add:");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                createContacts(); n--;
            }
        }
        public static void addMultiAddressBooks()
        {
            Dictionary<string, List<CreatContact>> group = new Dictionary<string, List<CreatContact>>();
            Console.WriteLine("How many address books you want to add: ");
            int noOfBooks = Convert.ToInt32(Console.ReadLine());
            while (noOfBooks > 0)
            {
                Console.WriteLine("Enter group name:");
                string gName = Console.ReadLine();
                addMultiContacts();
                group.Add(gName, Program.person);
                noOfBooks--;

            }
        }

    }

}
