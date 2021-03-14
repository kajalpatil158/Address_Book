using System;

namespace Problem6_Address_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel Come To Address Book System:");
            Console.WriteLine("Enter First Name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter City:");
            string City = Console.ReadLine();
            Console.WriteLine("Enter state:");
            string State = Console.ReadLine();
            Console.WriteLine("Enter Zip:");
            string Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            long PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email:");
            string Email = Console.ReadLine();



        }
    }
}
