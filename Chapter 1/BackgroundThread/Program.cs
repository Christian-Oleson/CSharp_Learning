using System;
using System.Threading;

namespace BackgroundThread
{
    class Program
    {
        static void Main()
        {
            var th = new ThreadStart(ThreadMethod);
            var t = new Thread(th)
            {
                IsBackground = false
            };
            t.Start();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(i);
            }
        }
    }
}
