using System;
using System.IO;
using System.Xml.Linq;

namespace lab_67_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nFirst XML Example \n\n");
            var xml01 = new XElement("testData",1);
            Console.WriteLine(xml01);

            Console.WriteLine("\n\nAdd A Sub-Element\n\n");
            var xml02 = new XElement("XMLRoot", new XElement("XMLData",100));
            Console.WriteLine(xml02);

            Console.WriteLine("\nSave As File\n");
            var xml03 = new XElement("XMLRoot", 
                new XElement("XMLData", 100),
                new XElement("XMLData", 200),
                new XElement("XMLData", 300),
                new XElement("XMLData", 400),
                new XElement("XMLData", 500)
                );
            Console.WriteLine(xml03);

            //write to the XML document
            var doc03 = new XDocument(xml03);
            doc03.Save("doc03.xml");
            Console.WriteLine(File.ReadAllText("doc03.xml"));

            // element is the TAG
            // attribute is the value INSIDE the tag
            // <TAG item = 500>

            Console.WriteLine("\nAdd Attributes\n");
            var xml04 = new XElement("XMLRoot",
                new XElement("XMLData", new XAttribute("height",196)),
                new XElement("XMLData", new XAttribute("weight",101)),
                new XElement("XMLData", new XAttribute("age",40))
                );
            Console.WriteLine(xml04);
        }
    }
}
