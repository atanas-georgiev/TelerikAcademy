using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02_DAOClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task2 - test DAO class
            var customer = DAO.GetCustomerById("ALFKI");

            if (customer == null)
            {
                Console.WriteLine("Customer do not exist!");
                Environment.Exit(0);
            }

            customer.Country = "Bulgaria";
            DAO.ModifyCustomer(customer);

            var customer2 = DAO.GetCustomerById("ALFKI");

            if (customer2 == null || customer2.Country != "Bulgaria")
            {
                Console.WriteLine("Customer2 is not changed!");
                Environment.Exit(0);
            }

            var customer3 = new Customer()
                                {
                                    CustomerID = "AAAAS",
                                    CompanyName = "Telerik",
                                    ContactName = "Nico",
                                    ContactTitle = "N",
                                    Address = "Mladost 1",
                                    City = "Sofia",
                                    Region = "Sofia",
                                    PostalCode = "1000",
                                    Country = "BG",
                                    Phone = "02 123457",
                                    Fax = "02 123457"
                                };

            DAO.AddCustomer(customer3);
            customer2 = DAO.GetCustomerById("AAAAS");

            if (customer2 == null)
            {
                Console.WriteLine("New customer not added!");
                Environment.Exit(0);
            }

            DAO.DeleteCustomer(customer2);

            if (customer2 != null)
            {
                Console.WriteLine("New customer not deleted!");
                Environment.Exit(0);
            }
        }
    }
}
