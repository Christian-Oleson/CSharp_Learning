using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelForeachFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });
        }
    }
}
