using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snap_lab_4_LINQ
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            // LINQ LAMBDA

            using(var db = new NorthwindEntities())
            {
                // FOREACH
                customers.ForEach(c => Console.WriteLine(c.ContactName));

                // Creating a sub-array from a larger list
                // e.g. Create an arry of Cities from our list of customers
                //Customer.City[] cities = db.Customers.Select(customer => customer.City).Distinct();

                // print the list
                Array.ForEach(cities, city => Console.WriteLine(city));
            }

        }
    }
}
