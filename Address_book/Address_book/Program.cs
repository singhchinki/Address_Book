using Address_book;
internal class Program 
{ 
    public static List<CreatContact> person = new List<CreatContact>(); 
    public static void Main(String[] args) 
    { Console.WriteLine("1.Create Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts\n5.Add Multiple Contacts\n6.Exit\n"); Console.WriteLine("Enter your choice:");
        int choice = Convert.ToInt32(Console.ReadLine()); 
        while (choice != 6) { Console.Clear(); 
            switch (choice)
            { case 1: Address_book.Person.createContacts();
                    break;
              case 2: Address_book.Person.editContacts();
                    break;
              case 3: Address_book.Person.removeContact(); 
                    break; 
              case 4: Address_book.Person.displayContacts();
                    break;
              case 5: Address_book.Person.addMultiContacts();
                    break;
                default: Console.Write("Enter valid option.\n");
                    break;
            } 
            Console.WriteLine("1.Create Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts\n5.Add Multiple Contacts\n6.Exit\n"); 
            Console.WriteLine("Enter your choice:");
            choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}

