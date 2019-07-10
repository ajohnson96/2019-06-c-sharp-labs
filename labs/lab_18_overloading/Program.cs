using System;

namespace lab_18_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rabbit();
            r.Age = 0;
            for(int i = 0; i<10; i++)
            {
                r.Grow();
                Console.WriteLine(r.Age);
            }

            Console.WriteLine("Hey\n\n It's summer now - growth rate is doubled! \n\n");

            for (int i = 0; i < 10; i++)
            {
                r.Grow(i);
                Console.WriteLine(r.Age);
            }

            Console.WriteLine("Hey\n\n It's winter now - growth rate is halved! \n\n");

            for (int i = 0; i < 10; i++)
            {
                r.Grow(0.5);
                Console.WriteLine(r.Age);
            }
        }
    }

    class Rabbit
    {
        public Double Age { get; set; }
        public void Grow()
        {
            Age++;
        }

        public void Grow(int growthFactor)
        {
            Age += growthFactor;
        }

        public void Grow(double wintergrowthFactor)
        {
            Age += wintergrowthFactor;
        }
    }

}
