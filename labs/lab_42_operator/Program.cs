using System;
using System.Linq;

namespace lab_42_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // x++
            int x01 = 100;
            int y01 = x01++;

            // ++x
            int x02 = 100;
            int y02 = ++x02;

            Console.WriteLine(!true);

            // modulus
            Console.WriteLine(100 % 8);

            // whole number after division
            Console.WriteLine(100 / 8);

            // && AND JUST ONE MORE THING...
            Console.WriteLine(1 & 1);   // 1
            Console.WriteLine(1 & 0);   // 0
            Console.WriteLine(0 & 1);   // 0
            Console.WriteLine(0 & 0);   // 0

            // | OR MAYBE JUST ONE MORE...
            Console.WriteLine(1 | 1);   // 1
            Console.WriteLine(1 | 0);   // 1
            Console.WriteLine(0 | 1);   // 1
            Console.WriteLine(0 | 0);   // 0

            // ^ BUT ONLY IF ONE OF US GETS TO HAVE IT
            Console.WriteLine(1 ^ 1);   // 0
            Console.WriteLine(1 ^ 0);   // 1
            Console.WriteLine(0 ^ 1);   // 1
            Console.WriteLine(0 ^ 0);   // 0

            // %% and || save time if right hand side
            // short-circuit operator : Can never be true so don't bother evaluating!!!
            //Console.WriteLine(true &&(DoThisLongOperation()));   // 1
            Console.WriteLine(false &&(DoThisLongOperation()));   // 1

            // BIT SHIFT
            // 1010 = 10 in decimal
            // 10100 = 20 
            // 101000 = 40
            // 1010 => 101 = 5
            Console.WriteLine(8 >> 2);
            Console.WriteLine(8 << 2);

            // TERNARY OPERATOR
            int num04 = 100;
            int num05 = 1000;
            if(num04 > num05)
            {
                // do this
            }
            else
            {
                // do that
            }

            //  OR YOU CAN JUST DO THIS:
            var output = (num04 > num05) ? "My Income" : "Student Debt";
            Console.WriteLine(output);

            // LAMBDA OPERATOR
            int[] myArray = { 1, 2, 3 };

            // create clone array 
            // but only values of a condition
            var outputArray01 = myArray.Where(item => item > 2);
            foreach(var item in outputArray01)
            {
                Console.WriteLine(item);
            }

            int?[] myArray2 = { null, 2, 3, null, 5, 6, null, 7, 8};

        }

        static bool DoThisLongOperation()
        {
            for(int i = 0; i<10000000;i++)
            {
                Console.WriteLine(i);
            }
            return false;
        }
    }
}
