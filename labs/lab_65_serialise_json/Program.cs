using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace lab_65_serialise_json
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(3011, "Jabbawocky", "New Jersey", "A1WL");
            var c02 = new Customer(3011, "Bandersnatch", "New York", "A2WL");
            var c03 = new Customer(3011, "Live-Action Sonic", "9th Circle of Dis", "HE11");
            //var customers = new List<Customer>() { c01, c02, c03 };

           // var JSONinstance01 = JsonConvert.SerializeObject(c01);
           // File.WriteAllText("data.json", JSONinstance01);

            //Console.WriteLine(File.ReadAllText("data.json"));

            //var customerListAsJSON = JsonConvert.SerializeObject(customers);
            //File.WriteAllText("customers.json", customerListAsJSON);

            //Console.WriteLine(File.ReadAllText("customers.json"));

            // send data around the world
            // at other end imagine now on a different computer
            // read ONE CUSTOMER
            //var customerFromJson = JsonConvert.DeserializeObject<Customer>(File.ReadAllText("data.json"));
            //Console.WriteLine(customerListAsJSON);
            //
            //var customerArray = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("customers.json"));
            //foreach(var c in customerArray)
            //{
            //    Console.WriteLine($"Reconstructed customer : {c.CustomerID} + {c.CustomerName} + {c.Address}");
            //}

           // var GITHUBcustomer = JsonConvert.DeserializeObject<Customer>(File.ReadAllText(""));
           // Console.WriteLine($"Reconstructed customer : {GITHUBcustomer.CustomerID} + {GITHUBcustomer.CustomerName} + {GITHUBcustomer.Address}");


            var downloadWebPage01 = new WebClient { Proxy = null };
            var GITHUBcustomers = new Uri("https://raw.githubusercontent.com/philanderson888/data/master/customers.json");
            downloadWebPage01.DownloadFile(GITHUBcustomers, "customers.json");
            //File.WriteAllText("customers.json", JSONinstance01);
        }
    }

    [Serializable]
    class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string Address { get; set; }

        [NonSerialized]
        private string NINO;

        public Customer(int customerID, string name, string address, string nino)
        {
            this.CustomerID = customerID;
            this.CustomerName = name;
            this.Address = address;
            this.NINO = nino;
        }

        public string GetNINO()
        {
            return NINO;
        }
    }
}
