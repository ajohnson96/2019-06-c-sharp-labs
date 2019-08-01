using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_59_debugging_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Debug.WriteLine($"Debugging to OUTPUT WINDOW (only in debug mode) : i is {i}");
                Trace.WriteLine($"Trace to OUTPUT WINDOW " + $"(in final release mode and debug mode) : i is {i}");
                //File.AppendAllText("output.txt", $"Logging to text file {DateTime.Now} i has value {i} ");
                //File.AppendAllText("C:\\Log Folder\\output.txt", $"Logging to text file {DateTime.Now} i has value {i} " + Environment.NewLine);
                //File.AppendAllText("Documents\\Log Folder\\output.txt", $"Logging to text file {DateTime.Now} i has value {i} ");

                string dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string path = dir + @"\Log\output.txt";
                File.AppendAllText(path, $"Logging to text file {DateTime.Now} i has value {i} " + Environment.NewLine);

                EventLog.WriteEntry("Application", "output", EventLogEntryType.Information, 5678, 123);
            }
            EventLog.WriteEntry("Application", "You have been hacked by /v/", EventLogEntryType.Information, 5678, 123);

            for(int j = 0; j <10;j++)
            {
                Console.WriteLine($"J has value {j}");
            }

            Console.ReadLine();
        }
    }
}
