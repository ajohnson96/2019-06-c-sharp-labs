using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace snap_lab_18_interfaces
{
    class Program
    {
        static List<Dog> dogs = new List<Dog>();
        static void Main(string[] args)
        {
            int[] dogHeights;

            Dog dog01 = new Dog(100);
            Dog dog02 = new Dog(10);
            Dog dog03 = new Dog(66);

            Console.WriteLine($"{dog01.CompareTo(dog02)}");
            Console.WriteLine($"{dog01.CompareTo(dog03)}");
            Console.WriteLine($"{dog02.CompareTo(dog03)}");

            dogs.Add(dog01);
            dogs.Add(dog02);
            dogs.Add(dog03);

            int highestNo = 0;
            int middleNo = 0;
            int lowestNo = 0;

            for (int i = 0; i < dogs.Count(); i++)
            {
                if (dogs[i].Height > lowestNo && lowestNo < middleNo)
                {
                    lowestNo = dogs[i].Height;
                }
                else if(dogs[i].Height > middleNo && middleNo < highestNo)
                {
                    middleNo = dogs[i].Height;
                }
                else if (dogs[i].Height > highestNo && highestNo >= middleNo)
                {
                    highestNo = dogs[i].Height;
                }
            }

            foreach(var h in dogs)
            {
                Console.WriteLine(h.Height);
            }

        }
    }

    class Dog : IComparable
    {
        public int Height { get; set; }
        public int CompareTo(object o)
        {
            Dog d = (Dog)o;
            if (this.Height <= d.Height) { return 0; };
            if (this.Height > d.Height) { return -1; };
            return Height.CompareTo(d);
        }

        public Dog(int height)
        {
            this.Height = height;
        }
    }
}
