using System;
using System.Diagnostics;
using System.Net;


namespace lab_63_web_streaming
{
    class Program
    {
        static void Main(string[] args)
        {

            var s = new Stopwatch();
            s.Start();
            GetWebPageSync();
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);

            var w = new Stopwatch();
            w.Start();
            GetWebPageAsync();
            w.Stop();
            Console.WriteLine(w.ElapsedMilliseconds);
        }

        static void GetWebPageSync()
        {
            var downloadWebPage01 = new WebClient { Proxy = null };
            var albarahi = new Uri("http://www.albahari.com/nutshell/code.aspx");
            downloadWebPage01.DownloadFile(albarahi, "albarahi.html");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "albahari.html");
        }

        async static void GetWebPageAsync()
        {
            var downloadWebPage01 = new WebClient { Proxy = null };

            var albarahi = new Uri("http://www.albahari.com/nutshell/code.aspx");
            await downloadWebPage01.DownloadFileTaskAsync(albarahi, "albarahi.html");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "albahari.html");
        }
    }
}
