using System;
using System.Linq;

namespace lab_30_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // pass in an integer
            // a) output a left-justified pyramid
            // 4
            /*
  
                *
                * *
                * * *
                * * * *
            */
            int i = 0;
            for(i=1;i<20;i++)
            {
                string star = string.Concat(Enumerable.Repeat("*", i));
                Console.WriteLine(star);
            }

            Console.ReadLine();

            // b) bonus: centre-justified pyramid
            // 4
            int j = 0;
            for (j = 1; j < 20; j++)
            {
                string star = string.Concat(Enumerable.Repeat("*", j));
                string space = string.Concat(Enumerable.Repeat(" ", 20 - j));
                Console.WriteLine(space + star + star);
            }

            /*
            int k = 0;
            for (k = 1; k < 20; k++)
            {
                string starUnder = string.Concat(Enumerable.Repeat("*", 20 - k));
                string space = string.Concat(Enumerable.Repeat(" ", k));
                Console.WriteLine(space + starUnder + starUnder);
            }
            */
            

            Console.ReadLine();
        }
    }
}
