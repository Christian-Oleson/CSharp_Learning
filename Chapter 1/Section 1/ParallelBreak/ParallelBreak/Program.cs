using System;
using System.Threading.Tasks;

namespace ParallelBreak
{
    class Program
    {
        private static void Main(string[] args)
        {
            var resultBreak = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                Console.WriteLine(i);
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }
            });

            var resultStop = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                Console.WriteLine(i);
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Stop();
                }
            });

            Console.WriteLine(resultBreak.IsCompleted);
            Console.WriteLine(resultStop.IsCompleted);
        }
    }
}
