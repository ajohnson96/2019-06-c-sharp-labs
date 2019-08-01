using System;

namespace lab_61_events_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scenario : Child will have a birthday
             Birthday is the EVENT
             HaveAParty is the METHOD
             We attach to an OOP INSTANCE ie var James = new Child();
            */

            var James = new Child();
            for(int i = 0; i<20; i++)
            {
                James.Grow();
            }
        }
    }

    class Child
    {
        public delegate int BirthdayDelegate();
        public static BirthdayDelegate OneYearOlder;
        public int Age { get; set; }

        public Child()
        {
            Age = 0;
            Console.WriteLine($"Congratulations On The Birth Of Your New Baby! Age is {Age}");
            OneYearOlder += HaveAParty; // event is no longer null
        }

        public void Grow()
        {
            // call the event
            OneYearOlder();
        }

        public int HaveAParty()
        {
            Age++;
            Console.Write($"\t\t\n\nCelebrating Birthday : Age is now {Age}");
            return Age;
        }
    }

}
