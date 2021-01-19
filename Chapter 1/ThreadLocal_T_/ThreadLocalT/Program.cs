using System;
using System.Threading;

namespace ThreadLocalT
{
    class Program
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        {
            return Thread.CurrentThread.ManagedThreadId;
        });

        static void Main()
		{
			new Thread(() =>
			{
				for (int x = 0; x < _field.Value; x++)
				{
                    Console.WriteLine($"Thread A: {x}");
				}
			}).Start();
			new Thread(() =>
			{
				for (int x = 0; x < _field.Value; x++)
				{
					Console.WriteLine($"Thread B: {x}");
				}
			}).Start();
		}
    }
}
