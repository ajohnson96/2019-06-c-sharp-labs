using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_52_LINQ_simple
{
    class Program
    {
        //static List<Customer> customers = new List<Customer>();
        static void Main(string[] args)
        {

            using (var db = new NorthwindEntities())
            {
                var output1 =
                        (from customer in db.Customers
                         select customer).ToList();
                PrintCustomers(output1);

                var output2 =
                    from c in db.Customers
                    where c.City == "London"
                    select c;
                PrintCustomers(output2.ToList());

                var output3 =
                    from c in db.Customers
                    orderby c.City descending
                    select c;
                PrintCustomers(output3.ToList());

                var output4 =
                    from c in db.Customers

                    select new
                    {
                        Name = c.ContactName,
                        Address = c.City + " " + c.Country
                    };
                foreach(var c in output4)
                {
                    Console.WriteLine($"{c.Name,-20} {c.Address}");
                }

                Console.WriteLine("\n\nGroup By - City\n\n");
                var output5 =
                    from c in db.Customers
                    group c by c.City into Cities
                    orderby Cities.Key
                    select new
                    {
                        City = Cities.Key,
                        Count = Cities.Count()
                    };
                foreach (var c in output5.ToList())
                {
                    Console.WriteLine($"{c.City, -20} {c.Count}");
                }

                using (var db2 = new NorthwindEntities())
                {
                    var output6 =
                        from customer in db2.Customers
                        join order in db2.Orders
                        on customer.CustomerID equals order.CustomerID
                        select new
                        {
                            Name = customer.ContactName,
                            order.OrderID,
                            order.OrderDate
                        };
                    output6.ToList().ForEach(x=>Console.WriteLine($"{x.Name, -25} {x.OrderID,-15} {x.OrderDate}"));
                }
                Console.ReadLine();
            }
        }

        static void PrintCustomers(List<Customer> customers)
        {
            foreach(var c in customers)
            {
                Console.WriteLine($"{c.ContactName,20} {c.CustomerID,20} ");
            }
            Console.ReadLine();
        }
    }
}
