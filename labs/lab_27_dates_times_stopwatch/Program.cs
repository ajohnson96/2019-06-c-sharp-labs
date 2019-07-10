using System;
using System.Diagnostics;
using System.Globalization;

namespace lab_27_dates_times_stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Times
            var time01 = DateTime.Now;
            Console.WriteLine(time01);
            Console.WriteLine(time01.ToLongDateString());

            // add units of time
            Console.WriteLine(time01.AddDays(1));
            Console.WriteLine(time01.AddSeconds(2));
            Console.WriteLine(time01.AddMilliseconds(5000).ToUniversalTime());
            Console.WriteLine(time01.AddTicks(500000000).ToUniversalTime());
            */

            // measure time with stopwatch;
            var s = new Stopwatch();
            s.Start();
            SayHello();

            // run code

            for (long i = 0; i < 10 ; i++)
            {
            }
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);
            Console.WriteLine(s.ElapsedTicks);

        }

        static public void SayHello()
        {
            string s01 = "Hello human ";
            string s02 = "How are you? ";
            string s03 = ":)";

            foreach (char c in s01)
            {
                System.Threading.Thread.Sleep(100);
                if (c == ' ')
                {
                    System.Threading.Thread.Sleep(200);
                }
                Console.WriteLine(c);

            }
            System.Threading.Thread.Sleep(400);
            foreach (char c in s02)
            {
                System.Threading.Thread.Sleep(100);
                if (c == ' ')
                {
                    System.Threading.Thread.Sleep(200);
                }
                Console.WriteLine(c);
            }
            System.Threading.Thread.Sleep(400);

            Console.WriteLine(s03);
        }
    }
}
