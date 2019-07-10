using System;
using System.Collections.Generic;

namespace Snap_Lab_Structs
{
    class Program
    {
        public static List<Point> Points = new List<Point>();
        static void Main(string[] args)
        {
            var point01 = new Point();
            var point02 = new Point();
            var point03 = new Point();

            point01.X = 4;
            point01.Y = 10;

            point02.X = 9;
            point02.Y = 12;

            point03.X = 3;
            point03.Y = 7;

            Points.Insert(0, point01);
            Points.Insert(1, point02);
            Points.Insert(2, point03);

            int HighestX = 0;
            int HighestY = 0;
            int LowestX = 0;
            int LowestY = 0;
            foreach(var point in Points)
            {
                if(point.X > HighestX)
                {
                    HighestX = point.X;
                    Console.WriteLine("New Highest X = " + HighestX);
                }

                if (point.Y > HighestY)
                {
                    HighestY = point.Y;
                    Console.WriteLine("New Highest Y = " + HighestY);
                }

                if(point.X < LowestX || LowestX == 0)
                {
                    LowestX = point.X;
                    Console.WriteLine("New Lowest X = " + LowestX);
                }

                if (point.Y < LowestY || LowestY == 0)
                {
                    LowestY = point.Y;
                    Console.WriteLine("New Lowest Y = " + LowestY);
                }
            }
            Console.WriteLine("Sum of Highest X - Lowest X = "  + (HighestX - LowestX));
            Console.WriteLine("Sum of Highest Y - Lowest Y = "  + (HighestY - LowestY));
        }
    }

    struct Point
    {
        public int X;
        public int Y;
    }
}
