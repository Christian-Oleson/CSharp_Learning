using System;
using System.Threading;

namespace QueingSomeWorkToThreadPool
{
    public class Program
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Queueing some work from the threadpool");
            });

            Console.ReadLine();
        }
    }
}
