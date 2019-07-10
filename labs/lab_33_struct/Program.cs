using System;

namespace lab_33_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Point(2, 3);
            var p02 = new Point(4, 7);
            var p03 = new Point(6, 12);
            Point p04;
        }
    }

    struct Y { }

    public struct Point
    {
        // store points on a graph
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
