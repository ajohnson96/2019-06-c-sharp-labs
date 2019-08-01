using System;

namespace lab_60_events_trivial
{
    class Program
    {
        // event 
        public delegate int Delegate01(string x);
        public static event Delegate01 Event01;
        static void Main(string[] args)
        {
            Event01 += Method01;
            Event01("Hello world special event");
        }

        static int Method01(string input)
        {
            Console.WriteLine("Hey you printing?");
            Console.WriteLine(input);
            return input.Length;
        }
    }
}
