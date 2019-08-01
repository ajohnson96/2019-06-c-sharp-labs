using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_51_entity_CRUD_app
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static void Main(string[] args)
        {
            AddNewCustomer();
            EditExistingCustomer();
            DeleteCustomer();
        }

        public static void AddNewCustomer()
        {
            Console.WriteLine("\n\nAdding New Customer\n==========\n");
            var newCustomer1 = new Customer()
            {
                ContactName = "Charlie Sheen",
                CompanyName = "Chuck Lorre Productions",
                CustomerID = "W1NNG",
                City = "Miami",
                Country = "U.S.A",
            };

            var newCustomer2 = new Customer()
            {
                ContactName = "Gary Sheen",
                CompanyName = "Chuck Lorre Productions",
                CustomerID = "L0SNG",
                City = "Miami",
                Country = "U.S.A",
            };

            using (var db = new NorthwindEntities())
            {
                var customerToDelete = customers.Find(x => x.CustomerID.Contains("W1NNG"));
                customers.Remove(customerToDelete);

                customers = db.Customers.ToList();
                customers.Add(newCustomer1);
                int affect = db.SaveChanges();
                Console.WriteLine($"Added affected records: {affect}");
            }

            ListAll(customers);
        }

        public static void EditExistingCustomer()
        {
            /* SELECT CUSTOMER */
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList();
                var customerToEdit = customers.Find(x => x.ContactName.Contains("Charlie"));
                
                /* UPDATE CUSTOMER */
                customerToEdit.ContactName = "Charlie Beenupdated";

                int affected = db.SaveChanges();
                Console.WriteLine($"You affected {affected} records");
                ListAll(customers);
            }
        }

        public static void DeleteCustomer()
        {
            /* DELETE CUSTOMER */
            var customerToDelete = customers.Find(x => x.ContactName.Contains("Charlie"));
            customers.Remove(customerToDelete);
            using (var db = new NorthwindEntities())
            {
                db.SaveChanges();
            }
            ListAll(customers);
        }

        public static void ListAll(List<Customer> CustomerList)
        {
            foreach(var customer in CustomerList)
            {
                Console.WriteLine($"{customer.ContactName, 20} {customer.CustomerID}");
            }
            Console.ReadLine();
        }
    }
}
