using System;

namespace lab_28_enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Colours.red);
            Console.WriteLine(Colours.green);
            Console.WriteLine(Colours.yellow);
            Console.WriteLine((int)Colours.notColour);


            Console.WriteLine((int)Colours.red);

            // use with days of week and months of year
            // sunday = 0, saturday = 6
            // January = 1, December = 12
            // e.g.
            var d = DateTime.Now;
            Console.WriteLine(d.Month); // 7
            Console.WriteLine(d.Day);   // 1

            Console.WriteLine((int)d.DayOfWeek);    //  1         0
            Console.WriteLine(d.DayOfWeek);         //  monday - sunday
        }
    }

    enum Colours
    {
        notColour = -1, red,green,yellow
    }
}
