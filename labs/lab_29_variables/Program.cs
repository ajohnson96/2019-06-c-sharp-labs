using System;

namespace lab_29_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte
            byte b01 = 0;       // Max
            byte b02 = 255;     // Min
            byte b03 = 0b_1010_0101;    // binary literal
            byte b04 = 0x_FF;
            byte b05 = 0x_0C;

            Console.WriteLine(b01);
            Console.WriteLine(b02);
            Console.WriteLine(b03);
            Console.WriteLine(b04);
            Console.WriteLine((int)b05);

            // buffer
            // YouTube: video split intop tiny parts
            // each part is size of a 'buffer'
            // 'video is buffering
            // buffer is an arry of bytes
            byte[] myBuffer = new byte[4000]; // chunk size for sending my video

            // char
            // ASCII : First computers maps a number of every character
            // h is 104 h is 72
            char char01 = 'c';
            char char02 = 'd';
            Console.WriteLine((int)char01);

            // unicode is upgrade to ASCII
            // utf-8 web getbootstrap
            // utf-16 unicode ==> chinese characters
            Console.Write("\u03B1");
            Console.Write("\u038F");
            //Console.WriteLine("θωερτψυιοπασδφγηςκλζχξωβνμ");

            // TUPLES
            void DoThis() { }
            int DoThat() { return -1; }

            void DoingSomething(out int result01, out string result02) { result01 = -1; result02 = "hi"; }

            // TUPLE IS AN ANONYMOUS TYPE
            (string x01, int y01, bool z01) DoingSomethingElse() { return ("hi", 10, false); }

            // Call Tuple
            var output = DoingSomethingElse();
            Console.WriteLine(output);

            // NULL-CHECK
            string authorName = null;
            
            // if name is not null, define nameLength and print it
            if (authorName != null)
            {
                int nameLength = authorName.Length;
                Console.WriteLine(nameLength);
            }

            // if name is null ==> return null
            int? nameLength2 = authorName?.Length;

            int? nullableItem = null;
            // int cannotMakeNull = null;
                

            // NULL-COALESCE
            

        }
    }
}
