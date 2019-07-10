using System;

namespace lab_26_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // signed integer can be positive or negative

            short s;        // length is 16 bits
            int i;          // length is 32 bits
            long l;         // length is 64 bits

            // capacity to store data (32,000, 2bil and 5 pentillion
            Int16 i16;      // length is 16 bits
            Int32 i32;      // length is 32 bits
            Int64 i64;      // length is 64 bits


            // unsigned integer can only be positive

            ushort uS;      // length is 16 bits
            uint uI;        // length is 32 bits
            ulong uL;       // length is 64 bits

            Console.WriteLine(short.MaxValue);  // 16 bits but one for sign, making 15. Ends up as 32768
            Console.WriteLine(ushort.MaxValue); // 16 bits or 65536, start at 0 and ends up 65535

        }
    }
}
