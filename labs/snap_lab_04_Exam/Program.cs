using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snap_lab_04_Exam
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static List<Product> products = new List<Product>();
        static List<Supplier> suppliers = new List<Supplier>();
        static List<Order> orders = new List<Order>();
        static List<Category> categories = new List<Category>();
        static List<Employee> employees = new List<Employee>();
        static List<Order_Detail> order_Details = new List<Order_Detail>();

        static System.Timers.Timer myTimer;
        static int numberOfRabbits = 0;
        static int elapsedTime = 0;


        static void Main(string[] args)
        {
            Question1_1();
            Question1_2();
            Question1_3();
            Question1_4();
            Question1_5();
            Question1_7();
            Question1_8();
            RabbitExplosion();
        }

        static void Question1_1()
        {
            using (var db = new NorthwindEntities())
            {
                Console.WriteLine("\n\n=====CUSTOMERS IN PARIS/LONDON=====");
                customers = db.Customers.ToList();

                foreach (var c in customers)
                {
                    if (c.City == "London")
                    {
                        Console.WriteLine($"\t\t{c.CustomerID}) {c.ContactName,-15} from {c.Address} lives in {c.City}");
                    }
                    else if (c.City == "Paris")
                    {
                        Console.WriteLine($"\t\t{c.CustomerID}) {c.ContactName,-15} from {c.Address} lives in {c.City}");
                    }
                }
                Console.ReadLine();
            }
        }

        static void Question1_2()
        {
            using (var db = new NorthwindEntities())
            {
                Console.WriteLine("\n\n=====PRODUCTS IN BOTTLES=====");
                products = db.Products.ToList();

                foreach(var p in products)
                {
                    if(p.QuantityPerUnit.Contains("bot"))
                    {
                        Console.WriteLine($"\t\t{p.ProductID}) {p.ProductName,-15} is sold in {p.QuantityPerUnit}");
                    }
                }
                Console.ReadLine();
            }
        }

        static void Question1_3()
        {
            using (var db = new NorthwindEntities())
            {
                Console.WriteLine("\n\n=====PRODUCTS IN BOTTLES=====");
                products = db.Products.ToList();
                var suppliers =
                from Supplier in db.Suppliers
                join Product in db.Products
                on Supplier.SupplierID equals Product.SupplierID
                select new
                {
                    Name = Supplier.CompanyName,
                    countryName = Supplier.Country,
                };

                foreach (var p in products)
                {
                    if (p.QuantityPerUnit.Contains("bot"))
                    {
                        Console.WriteLine($"\t\t{p.ProductID}) {p.ProductName,-15} is sold in {p.QuantityPerUnit} by {p.Supplier.CompanyName} from {p.Supplier.Country}");
                    }
                }
                Console.ReadLine();
            }
        }

        static void Question1_4()
        {
            using (var db = new NorthwindEntities())
            {
                Console.WriteLine("\n\n=====PRODUCTS IN CATEGORY=====");
                products = db.Products.ToList();
                categories = db.Categories.ToList();

                foreach (var c in categories.OrderByDescending(x => x.Products.Count))
                {
                    Console.WriteLine($"\t\tCategory {c.CategoryName, -15} has {c.Products.Count} products");
                }

                Console.ReadLine();
            }
        }

        static void Question1_5()
        {
            using (var db = new NorthwindEntities())
            {
                Console.WriteLine("\n\n=====ALL UK EMPLOYEES=====");
                employees = db.Employees.ToList();

                foreach (var e in employees.Where(x => x.Country == "UK"))
                {
                    var fullName = e.TitleOfCourtesy.ToString() + " " + e.FirstName.ToString() + " " + e.LastName.ToString();
                    Console.WriteLine($"\t\t{fullName,-15} lives at {e.City}");
                }

                Console.ReadLine();
            }
        }

        static void Question1_7()
        {
            using (var db = new NorthwindEntities())
            {
                Console.WriteLine("\n\n=====ORDERS WITH FREIGHT OVER 100=====");
                orders = db.Orders.ToList();

                foreach (var o in orders.OrderByDescending(y => y.Freight).Where(x => x.Freight >= 100))
                {
                    if(o.ShipCountry == "USA")
                    {
                        Console.WriteLine($"\t\t{o.ShipName} freight is {o.Freight}");
                    }
                    else if (o.ShipCountry == "UK")
                    {
                        Console.WriteLine($"\t\t{o.ShipName} freight is {o.Freight}");
                    }
                }
                Console.ReadLine();
            }
        }

        static void Question1_8()
        {

            using (var db = new NorthwindEntities())
            {
                Console.WriteLine("\n==== 1.8 =====\n");
                var orders = from od in db.Order_Details select od;
                var discountAmount = new List<decimal>();
                foreach (var od in orders)
                {
                    discountAmount.Add((decimal)od.Discount * od.UnitPrice * od.Quantity);
                }
                var highestDiscount = discountAmount.Max();
                Console.WriteLine($"Highest Discount: {highestDiscount}");
                /*
                Console.WriteLine("\n\n=====ORDER WITH HIGHEST DISCOUNT=====");
                orders = db.Orders.ToList();
                order_Details = db.Order_Details.ToList();
                //var preDiscount = db.Order_Details.ToList().Where(c => c.Discount != 0).Select(p => (p.UnitPrice * p.Quantity));
                var postDiscount = db.Order_Details.ToList().Where(c => c.Discount > 0.0).Select(m => (m.UnitPrice * m.Quantity) * (decimal)(1 - m.Discount)).Max();
                foreach (var o in orders)
                {
                    if (o.Order_Details.ToList().Select(d => (d.UnitPrice * d.Quantity) * (decimal)(1 - d.Discount)).Max() == postDiscount)
                    {
                        Console.WriteLine($"\t\tThe order with the highest discount is {o.OrderID} with value of {postDiscount}");
                    }
                }*/
            }
            Console.ReadLine();
        }

        static void RabbitExplosion()
        {
            Console.WriteLine($"\n\n=====RABBIT EXPLOSION=====");
            numberOfRabbits +=1;
            myTimer = new System.Timers.Timer();
            myTimer.Interval = 1000;

            myTimer.Elapsed += DoubleRabbits;
            myTimer.AutoReset = true;
            myTimer.Enabled = true;

            Console.ReadLine();
        }

        static void DoubleRabbits(Object source, System.Timers.ElapsedEventArgs e)
        {
            if(numberOfRabbits >= 1000000)
            {
                myTimer.Enabled = false;
                Console.WriteLine($"\t\tRabbit population reached the limit in {elapsedTime * 10} milliseconds!");
            }
            else
            {
                numberOfRabbits = numberOfRabbits * 2;
                Console.WriteLine($"\t\t{elapsedTime} seconds in, the rabbit population is {numberOfRabbits}");
                elapsedTime++;
            }
        }
    }
}
