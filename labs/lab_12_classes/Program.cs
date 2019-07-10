using System;
using System.Collections.Generic;

namespace lab_12_classes
{
    class Program
    {
        static List<Dog> dogs = new List<Dog>();
        static void Main(string[] args)
        {
            var m01 = new Mammal();
            m01.Height = 100;
            m01.Length = 150;
            m01.Weight = 2000;

            var d01 = new Dog();
            d01.Height = 80;
            d01.Length = 50;
            d01.Weight = 1000;
            d01.DogID = "Dog01";

            Console.WriteLine($"Dog has height {d01.Height}, weight {d01.Weight} and length {d01.Length}");

            for (int i = 1; i <= 20; i++)
            {
                // Same height, length and width but different ID
                Dog newdog = new Dog();
                newdog.DogID = $"{i}";
                newdog.Height = 100;
                newdog.Weight = 2000;
                newdog.Length = 150;

                dogs.Add(newdog);
            }

            foreach(var Dog in dogs)
            {
                Console.WriteLine($"Dog number {Dog.DogID}, has height {d01.Height}, weight {d01.Weight} and length {d01.Length}");
            }
        }
    }

    class PitBull : Dog { }
    class Dog : Mammal { }
    class Cat : Mammal { }
    class Mammal
    {
        public int Height;
        public int Weight;
        public int Length;
        public string DogID;

    }
}
