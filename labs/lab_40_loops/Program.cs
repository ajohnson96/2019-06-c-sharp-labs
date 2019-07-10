using System;

namespace lab_40_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for
            // When you wish to run a task x number of times.

            // foreach
            // When you wish to apply something to each member of a collection

            // while
            // Essentially an If statement

            // do ... while 
            // same as a while but will do it at least once

            // break

            // continue
            string stringToBreak = null;
        }

        // throw
        public void Thrower(string value)
        {
            // Generate new exception.
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
        }

        // return
        public int DoThis(int inputNumber)
        {
            var output = DoThis(10);
            if (inputNumber == 9)
            {
            }
            else if (inputNumber == 10)
            {
            }
            else if (inputNumber == 11)
            {
            }
            return -1000;
        }
    }
}
