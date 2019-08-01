using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace lab_50_async
{
    class Program
    {
        static void Main(string[] args)
        {
            //var counter = 0;

            // create a big text file
            // use 'streamwriter' to write a stirng as a stream to a file
            /*using (var writer = new StreamWriter("data.dat"))
            {
                writer.WriteLine($"{counter,-5} new line {DateTime.Now}");
                for(int i = 0; i<10000000;i++)
                {
                    writer.WriteLine($"{i,-5} new line {DateTime.Now}");
                }
            }*/
            ReadSync();
            ReadDataAsync();
            Console.ReadLine();
        }

        static void ReadSync()
        {
            var s = new Stopwatch();
            s.Start();

            // using can encapsulate a method which is reaching outside of the clean C# namespace (AIRLOCK)

            // STRINGBUILDER can be used EASILY CONSTRUCT a long string from lots of little inputs
            var stringbuilder = new StringBuilder();
            //string longstring = "";

            using (var reader = new StreamReader("data.dat"))
            {
                while(!reader.EndOfStream)
                {
                    stringbuilder.Append(reader.ReadLine());
                    //longstring += reader.ReadLine();
                    //Console.WriteLine(reader.ReadLine());
                }
            }
            s.Stop();
            Console.WriteLine($"Reading 10,000,000 lines took: {s.ElapsedMilliseconds / 1000} seconds");
            System.Threading.Thread.Sleep(1000);
        }

        async static void ReadDataAsync()
        {
            var w = new Stopwatch();
            w.Start();
            string line = null;
            var stringBuilder = new StringBuilder();

            using (var reader = new StreamReader("data.dat"))
            {
                while(true)
                {
                    line = await reader.ReadLineAsync();
                    if (line == null) break;
                }
            }
            w.Stop();
            Console.WriteLine($"Reading 10,000,000 lines async took: {w.ElapsedMilliseconds} seconds");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
