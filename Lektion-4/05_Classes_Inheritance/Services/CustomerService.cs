
using _05_Classes_Inheritance.Models;

namespace _05_Classes_Inheritance.Services
{
    internal class CustomerService
    {
        private static List<Customer> customers = new List<Customer>();
        public static void CreatePrivateCustomer()
        {
            var customer = new PrivateCustomer();

            Console.WriteLine("Ange förnamn: ");
            customer.FirstName = Console.ReadLine() ?? "";

            Console.WriteLine("Ange efternamn: ");
            customer.LastName = Console.ReadLine() ?? "";

            Console.WriteLine("Ange email: ");
            customer.Email = Console.ReadLine() ?? "";

            Console.WriteLine("Ange telefonnummer: ");
            customer.PhoneNumber = Console.ReadLine() ?? "";

            customers.Add(customer);
            Console.WriteLine("En ny privatkund har lagts till i listan.");
        }

        public static void CreateCompanyCustomer()
        {
            var customer = new CompanyCostumer();
            Console.WriteLine("Ange företagsnamn: ");
            customer.CompanyName = Console.ReadLine() ?? "";

            Console.WriteLine("Ange e-postadress: ");
            customer.Email = Console.ReadLine() ?? "";

            Console.WriteLine("Ange telefonnummer: ");
            customer.PhoneNumber = Console.ReadLine() ?? "";


            customers.Add(customer);
            Console.WriteLine("En ny företagskund har lagts till i listan.");
        }
    }
}
