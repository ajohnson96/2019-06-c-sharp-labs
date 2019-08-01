using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab_66_serialize_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(3011, "Jabbawocky", "New Jersey", "A1WL");
            var c02 = new Customer(3011, "Bandersnatch", "New York", "A2WL");
            var c03 = new Customer(3011, "Live-Action Sonic", "9th Circle of Dis", "HE11");
            var customers = new List<Customer>() { c01, c02, c03 };

            // perform the serialization
            var binaryFormatter = new BinaryFormatter();

            // stream the serialized data - to a file in this case but could be web or RAM
            using (var binaryStream = new FileStream("data.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // write data to file
                binaryFormatter.Serialize(binaryStream, customers);
            }
            Console.WriteLine(File.ReadAllText("data.bin"));

            // send data across the world and de-serialize at the other end
            var customersFromBinary = new List<Customer>();
            using (var reader = File.OpenRead("data.bin"))
            {
                customersFromBinary = binaryFormatter.Deserialize(reader) as List<Customer>;
            }

            // iterate and print out
            foreach(var c in customersFromBinary)
            {
                Console.WriteLine($"Reconstructed customer : {c.CustomerID} + {c.CustomerName} + {c.Address}");
            }
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
