using System;
using System.Collections;
using System.Collections.Generic;
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

            ArrayList list = new ArrayList();
            list.Add(FirstName);
            list.Add(LastName);
            list.Add(Address);
            list.Add(City);
            list.Add(State);
            list.Add(Zip);
            list.Add(PhoneNumber);
            list.Add(Email);

            

            //Console.WriteLine("Added item in is {0}", list);

            foreach (var i in list )
                {
                Console.WriteLine(i);
                }



        }
    }
}
