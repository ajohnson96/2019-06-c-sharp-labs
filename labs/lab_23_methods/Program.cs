using System;

namespace lab_23_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var z = new X();

            // Grow() : instance method
            z.Grow();

            // ReturnFixedData(): static method
            X.ReturnFixedData();

            // remember STATIC MATHS CALLS WHICH RETURNS PI, LOGX, ETC
            Console.WriteLine(Math.PI);

            DoingLots(100, "hi", true);
            DoingLots(c: false, b: "there", a: 10000);

            Console.ReadLine();
        }
        // or here
        static void DoingLots(int a, string b, bool c)
        {
            Console.WriteLine($"Doing lots {a} {b} {c}");
            //DoingSomeOtherWork(new DateTime(2019, 06, 27)); // set the date but others default
            DoingSomeOtherWork(new DateTime(2019, 06, 27), 1666.666, 'c'); // set the rest
        }

        static void DoingSomeOtherWork(DateTime date, double d = 100.329, char c = 'z')
        {
            string newDate = date.ToShortDateString();
            string weekday = date.DayOfWeek.ToString();
            Console.WriteLine($"{weekday},{d},{c}");
        }
    }

    class X
    {
        public int Age;
        // or here!
        public void Grow()
        {
            Age++;
            Console.WriteLine(Age);
        }

        // static methods are useful for fixed data, for example warehouse stock
        public static string ReturnFixedData()
        {
            Console.WriteLine("Here is some fixed data");
            return "Here is some fixed data";
        }
    }

}
