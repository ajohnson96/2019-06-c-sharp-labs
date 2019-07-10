using System;
using System.Collections.Generic;
using System.Threading;

namespace lab_16_rabbits
{

    class RabbitProgram
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        static void Main(string[] args)
        {

            for(int i = 1; i<=100;i++)
            {
                // create new rabbit;
                Rabbit newrabbit = new Rabbit(0,i);

                // add new rabbit
                rabbits.Add(newrabbit);

                // print each rabbit
                Console.WriteLine(newrabbit.GetName("Anything"));

                foreach (Rabbit r in rabbits)
                {
                    r.Age++;
                    Console.WriteLine($"{r.GetName("Name"),-20} {r.Age}");
                }

                // wait 200 milliseconds ie 1/5 second
                System.Threading.Thread.Sleep(200); 
            }
        }
    }

    class Rabbit
    {
        public int Age { get; set; }
        private string Name { get; set; }

        public Rabbit(int Age, int counter)
        {
            this.Age = Age;
            this.Name = "Rabbit" + counter;
        }

        public string GetName(string name)
        {
            name = this.Name;
            return name;
        }

        public int GetAge(int newAge)
        {
            newAge++;
            return newAge;
        }

    }

    // phase 1: build the loop
    // phase 2: each loop also adds 1 year to the age of each rabbit
    // phase 3:     a)build a WPF app with a rabbit background/image
    //              b)button
    //              c)no timer but manual button click. 
    //                  i)increment age of all existing rabbits.
    //                  ii)Also creates a new rabbit with age 0 to be added to list
    //                  iii) View LISTBOX clear every click and rebuild rabbit list every time
}
