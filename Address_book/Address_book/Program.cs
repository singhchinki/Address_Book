using Address_book;
internal class Program
{
    public static List<CreatContact> person = new List<CreatContact>();
    public static void Main(String[] args)
    {
        Console.WriteLine("1.Create Contact\n2.Edit Contact\n3.Delete Contact\n4.Display Contacts\n5.Add Multiple Contacts\n6.Add Multi Address Bookn\n7.Search By City or State\n8 Display by city or state\n9.Write To file\nExit\n");
        Console.WriteLine("Enter your choice:");
        Person p = new Person();
        int choice = Convert.ToInt32(Console.ReadLine());
        while (choice != 9)
        {
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Address_book.Person.createContacts();
                    break;
                case 2:
                    Address_book.Person.editContacts();
                    break;
                case 3:
                    Address_book.Person.removeContact();
                    break;
                case 4:
                    p.displayContacts();
                    break;
                case 5:
                    p.addMultiContacts();
                    break;
                case 6:
                    p.addMultiAddressBooks();
                    break;
                case 7:
                    p.searchByCityOrState();
                    break;
                case 8:
                    p.displayByCityOrState();
                    break;
                case 9: p.WriteToFile();
                    break;

                default:
                    Console.Write("Enter valid option.\n");
                    break;
            }
            
        }
    }


}
