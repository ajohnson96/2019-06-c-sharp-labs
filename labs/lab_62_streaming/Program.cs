using System;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace lab_62_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();

            // stream to WRITE A FILE
            using (var writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < 10000; i++)
                {
                    writer.WriteLine($"Line {i + 1} - adding some text {DateTime.Now} : {s.ElapsedTicks}");
                }
                writer.Close();
            }
            s.Stop();

            var t = new Stopwatch();
            t.Start();

            // see if string builder is faster
            var stringbuilder = new StringBuilder();
            for(int i=0; i<10000;i++)
            {
                stringbuilder.AppendLine(($"\n\nLine {i + 1} - adding some text {DateTime.Now} : {t.ElapsedTicks}\n\n"));
            }
            using (var writer = new StreamWriter("output2.txt"))
            {
                writer.WriteLine(stringbuilder);
            }
            t.Stop();

            var u = new Stopwatch();
            u.Start();

            string nextline;
            var stringbuilder2 = new StringBuilder();
            using (var reader = new StreamReader("output.txt"))
            {
                // two operations 1)read next line and assign into string 'nextline' AND 2) check has not returned null
                while((nextline = reader.ReadLine()) != null)
                {
                    stringbuilder2.AppendLine(nextline);
                }
            }
            Console.WriteLine($"Read file to memory {u.ElapsedTicks}");
            Console.ReadLine();
            //Console.WriteLine(stringbuilder2);
            Console.WriteLine($"output file to memory {u.ElapsedTicks}");
            u.Stop();


            // last example - streaming to memory (used eg in encryption)
            // use a point (reference to an address in memory)
            // read data from pointer forwards

            using (var memoryStream = new MemoryStream())
            {
                var buffer = new byte[100];
                buffer[0] = (int)'h';
                buffer[1] = (int)'e';
                buffer[2] = (int)'l';
                buffer[3] = (int)'l';
                buffer[4] = (int)'o';

                // write data to memory
                memoryStream.Write(buffer);
                memoryStream.Flush();       // actively push remaining data to memory

                // get meaningful data back
                // reset pointer to 0
                memoryStream.Position = 0;
                var reader = new StreamReader(memoryStream);
                Console.WriteLine(reader.ReadToEnd());
                reader.ReadLine();
            }
        }
    }
}
