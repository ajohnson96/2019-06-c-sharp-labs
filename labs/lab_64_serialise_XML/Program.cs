using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace lab_64_serialise_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            var c01 = new Customer(3011, "Bandersnatch", "NYC", "WA11");

            var formatter = new SoapFormatter();
            // XML serialise into a FILE STREAM
            using (var fileStream = new FileStream("data.xml",FileMode.Create, FileAccess.Write, FileShare.None, 4096))
            {
                formatter.Serialize(fileStream, c01);
            }

            Console.WriteLine(File.ReadAllText("data.xml"));

            // imagine on another computer : can we reconstruct instance?
            Customer customerFromXML;
            using (var streamReader = File.OpenRead("data.xml"))
            {
                // deserialise back into the instance of the class
                customerFromXML = formatter.Deserialize(streamReader) as Customer;
            }

            Console.WriteLine($"Reconstructed customer : {customerFromXML.CustomerID} + {customerFromXML.CustomerName} + {customerFromXML.Address}");
            Console.WriteLine($"NINO is blank !!! {customerFromXML.GetNINO()}");
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
