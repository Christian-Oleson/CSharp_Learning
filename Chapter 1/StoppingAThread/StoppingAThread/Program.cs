using System;
using System.Threading;

namespace StoppingAThread
{
    public static class Program
    {
        static void Main()
        {
            bool stopped = false;
            var t = new Thread(new ThreadStart(() =>
            {
                while(!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }
    }
}
