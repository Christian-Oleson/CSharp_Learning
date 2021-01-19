using System;
using System.Threading;
using System.Threading.Tasks;

namespace StartingNewTask
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var t = Task.Run(() => StartingNewTask());

            t.Wait();
        }

        public static void StartingNewTask()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Running...");
            }
        }
    }
}
