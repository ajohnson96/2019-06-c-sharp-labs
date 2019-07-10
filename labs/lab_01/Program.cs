using System;

namespace lab_01
{
    class Program
    {
        private static string msg;

        static void Main(string[] args)
        {
            int x = default;
            Console.WriteLine(x);
            string y = default;
            Console.WriteLine(y);
            Console.WriteLine(y == null);
            Console.WriteLine(y == "");

            var f = 1.23f;
            Console.WriteLine(f);
            var f02 = (2*10^30);

            Console.WriteLine(f02);

            //
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            // highest degree of precision in calculations (eg money)
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            // use with exponential numbers (e.g 2*10^30)
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            // care when equating decimal numbers!
            var d01 = 0.1M;
            var d02 = 0.2M;
            Console.WriteLine(d01 + d02 == 0.3M);

        }
    }
}
