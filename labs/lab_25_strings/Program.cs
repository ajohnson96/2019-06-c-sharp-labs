using System;
using System.Text.RegularExpressions;

namespace lab_25_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01 = int.Parse("1234");
            Console.WriteLine(num01);
            Console.WriteLine($"Type of num01 is {num01.GetType()}");

            try
            {
                int num02 = int.Parse("1234sometext");
                Console.WriteLine(num02);
                Console.WriteLine($"Type of num01 is {num02.GetType()}");

                int num03 = int.Parse("sometext1234sometext");
                Console.WriteLine(num03);
                Console.WriteLine($"Type of num01 is {num03.GetType()}");

                int num04 = int.Parse("sometext");
                Console.WriteLine(num04);
                Console.WriteLine($"Type of num01 is {num04.GetType()}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Don't use parse!!!");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("back to normal");
            }

            int result = Convert.ToInt32
                (
                    Regex.Replace
                    (
                        "7yu4805jqwfwei321",    // input
                        "[^0-9]",               // select everything that is not in the range of 0-9
                        ""                      // replace that with an empty string.
                    )
                );
            Console.WriteLine(result);

            Console.ReadLine();

            // string.Format and String Interpolation
            double d01 = 1.234;
            Console.WriteLine($"{d01,20:N0}{d01,20:N1}{d01,20:N2}");

            // currency
            Console.WriteLine($"{d01,20:C}");

            // splitting strings
            string sentence = "Food is life";
            string[] words = sentence.Split(' ');
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }

            // bringing them back together
            string restOfArray = string.Join(" ", words);
            Console.WriteLine(restOfArray);


            /*
                    StartsWith
                    Contains
                    Trim/TrimsStart/TrimEnd
                    ToUpper/ToLower
                    .Insert/Remove
                    .Replace
                    .Concat
                    .IsNullOrEmpty
                    .IsNullOrWhiteSpace
                    .Empty
            */

            // INSERT/REMOVE
            // initialise and write original string
            String original = "abc123";                                 
            Console.WriteLine("The original string: '{0}'", original);

            // Insert white space after character 3
            String modified = original.Insert(3, " "); 
            Console.WriteLine("The modified string: '{0}'", modified);

            // Remove 1 character after character 3 (white space from before)
            Console.WriteLine("The modified string is: {0}", modified.Remove(3, 1));
        }
    }
}
