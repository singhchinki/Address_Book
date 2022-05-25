﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book
{
    internal class AbilityToEdit
    {
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
                        case 1: Console.WriteLine("Enter First Name to update:");
                            contact.fName = Convert.ToString(Console.ReadLine());
                            break;
                        case 2: Console.WriteLine("Enter Last Name to update:");
                            contact.lName = Convert.ToString(Console.ReadLine());
                            break; 
                        case 3: Console.WriteLine("Enter Address to update:");
                            contact.address = Convert.ToString(Console.ReadLine());
                            break;
                        case 4: Console.WriteLine("Enter City to update:");
                            contact.city = Convert.ToString(Console.ReadLine());
                            break;
                        case 5: Console.WriteLine("Enter State to update:");
                            contact.state = Convert.ToString(Console.ReadLine());
                            break;
                        case 6: Console.WriteLine("Enter Zip code to update:");
                            contact.zip = Convert.ToInt32(Console.ReadLine());
                            break; 
                        case 7: Console.WriteLine("Enter Phone to update:");
                            contact.phoneNo = Convert.ToDouble(Console.ReadLine());
                            break; 
                        case 8: Console.WriteLine("Enter Email to update:");
                            contact.email = Convert.ToString(Console.ReadLine());
                            break;
                        default: Console.WriteLine("Invalid option:"); 
                            break; 
                    } 
                } 
            } 
        }
    }
}
