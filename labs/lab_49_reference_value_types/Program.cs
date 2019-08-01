using System;

namespace lab_49_reference_value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // value types
            int x = 10;
            int y = x;
            y = 100;
            Console.WriteLine("x is " + x + " and y is " + y);

            // reference types
            int[] array_a = new int[] { 10 , 20, 30 };
            int[] array_b = array_a;

            // new for-each loop
            Console.WriteLine("\n\nBefore changes\n");
            Array.ForEach(array_a, item => Console.WriteLine(item));
            Array.ForEach(array_b, item => Console.WriteLine(item));

            array_a[0] += 10;
            array_b[2] -= 10;

            Console.WriteLine("\n\nAfter changes\n");
            Array.ForEach(array_a, item => Console.WriteLine(item));
            Array.ForEach(array_b, item => Console.WriteLine(item));

            Console.WriteLine("\n\nAfter final changes\n");
            var array_c = (int[])array_b.Clone();
            for(int i = 0; i>3;i++)
            {
                Console.WriteLine(array_c[i] + 5);
            }
        }
    }
}
