<Query Kind="Program" />

void Main()
{
	
            var th = new ThreadStart(ThreadMethod);
            var t = new Thread(th)
            {
                IsBackground = false
            };
            t.Start();
}

// You can define other methods, fields, classes and namespaces here

        public static void ThreadMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"ThreadProc: {i}");
                Thread.Sleep(i);
            }
        }