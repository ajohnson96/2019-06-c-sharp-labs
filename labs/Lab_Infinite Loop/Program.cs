using System;
using System.IO;

namespace Lab_Infinite_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10000;i++)
            {
                CrashMe();
            }
        }

        static void CrashMe()
        {
            int? x = null;
            try
            {
                var filecontents = File.ReadAllText("youwon'tfindme.txt");
                Console.WriteLine(x.Value);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Null Referece");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("File Not Found");
            }
            catch(Exception e)
            {
                Console.WriteLine("general exception");
            }
        }
    }
}
