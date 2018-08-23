using Database.Models;
using Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            PortalDbContext portal = new PortalDbContext();

            Person person = new Person();
            Console.WriteLine("First Name: ");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Middle Name: ");
            person.MiddleName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Father Name: ");
            person.FatherName = Console.ReadLine();
            Console.WriteLine("Grandfather Name: ");
            person.GrandFatherName = Console.ReadLine();
            Console.WriteLine("Date: ");
            person.BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Citizen No: ");
            person.CitizenshipNumber = Console.ReadLine();
            person.AddressId = 1;
            Console.WriteLine("\nPress Enter to save to database.");
            Console.ReadLine();

            portal.Persons.Add(person);
            Console.WriteLine("\nSuccessfully added to the database");
            portal.SaveChanges();
        }
    }
}
