using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_book
{
    internal class AbilityToDelete
    {
        public static void removeContact() 
        {
            Console.WriteLine("Enter Name of person to delete details: ");
            
            string name = Console.ReadLine();
            foreach (var contact in Program.person.ToList())
            {
                if (contact.fName.Equals(name)) 
                {
                    Program.person.Remove(contact);
                } 
            } 
        }
       
    }
}
