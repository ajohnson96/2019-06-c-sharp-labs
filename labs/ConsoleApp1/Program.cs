using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static List<Product> products = new List<Product>();
        static List<Order> orders = new List<Order>();
        static List<Category> categories = new List<Category>();

        static void Main(string[] args)
        {
            int countCustomer = 0;
            int countProduct = 0;
            int countOrder = 0;
            decimal sumOfOrders = 0;


            using (var db = new NorthwindEntitiesNew())
            {
                // how many customers
                foreach(var c in db.Customers)
                {
                    countCustomer++;
                }
                Console.WriteLine(countCustomer);
                
                // how many products
                foreach (var p in db.Products)
                {
                    countProduct++;
                }
                Console.WriteLine(countProduct);

                // how many orders
                foreach (var o in db.Orders)
                {
                    countOrder++;
                }
                Console.WriteLine(countOrder);

                // print the average order value

                foreach (var o in db.Order_Details)
                {
                    sumOfOrders += (o.UnitPrice * o.Quantity);
                }

                Console.WriteLine("The Sum of Orders is: ");
                Console.WriteLine(sumOfOrders);

                
                Console.WriteLine("The Average Order Price is: ");
                Console.WriteLine(sumOfOrders / countOrder);



                // way to join 2 tables using 'dot' notation
                // look at products and categories
                // goal : list categories in order for each category count products and list individual product names
                Console.WriteLine("\n\n=====================CATEGORIES=====================");
                categories = db.Categories.ToList();
                products = db.Products.ToList();

                foreach(var c in categories)
                {
                    Console.WriteLine($"\t\t{c.CategoryID}) {c.CategoryName, -15} has {c.Products.Count} products");

                    Console.WriteLine("\n\n\t\t==========Products==========");

                    foreach(var p in c.Products)
                    {
                        Console.WriteLine($"\t\t\t{p.ProductID} is {p.ProductName}");
                    }

                }


                Console.ReadLine();
            }
        }
    }
}
