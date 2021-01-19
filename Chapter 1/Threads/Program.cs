using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main()
		{
			var ts = new ThreadStart(ThreadMethod);
			var t = new Thread(ts);
			t.Start();

			for (int i = 0; i < 4; i++)
			{
				string m = $"Main thread is doing some work...";
                Console.WriteLine(m);
				Thread.Sleep(0);
			}
		}
		public static void ThreadMethod()
		{
			for (int i = 0; i < 10; i++)
			{
				string message = $"Thread prod: {i}";
                Console.WriteLine(message);
				Thread.Sleep(0);
			}
		}
	}
}
