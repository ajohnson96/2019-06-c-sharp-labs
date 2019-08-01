using System;

namespace lab_58_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Child();
            c.Name = "Roberto II";
            c.Property01 = 100;
            c.UseTool01();

            Console.WriteLine($"{c.Name} has a parent who {c.UseTool01()}'s");
        }
    }

    interface IToolShedItem01
    {
        //-----No Fields allowed!-----//
        /*public int Field01;*/

        int Property01 { get; set; }  // 'Public' present but not stated
        string UseTool01();           // Abstract AND public, but not stated

    }
    interface IToolShedItem02 { }

    abstract class Parent
    {
        public string Name { get; set; }
        public abstract string DoThis();
    }

    class Child : Parent, IToolShedItem01, IToolShedItem02
    {
        public int Property01 { get; set; } 
        public override string DoThis() => "Hello"; // mandatory abstract override

        public string UseTool01() => $"owns {Property01} shovel".Trim(); 
    }
}


