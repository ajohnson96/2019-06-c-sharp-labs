using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_17_rabbit_explosion
{
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
}
