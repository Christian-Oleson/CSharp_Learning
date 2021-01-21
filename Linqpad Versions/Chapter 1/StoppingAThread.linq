<Query Kind="Program" />

void Main()
{
	bool stopped = false;
	var ts = new ThreadStart(ThreadMethod);
	var t = new Thread(ts => 
	{
		while(!stopped)
		{
			("Running...").Dump();
			Thread.Sleep(1000);
		}
	});
	t.Start();
	"Press any key to exit".Dump();
	Console.ReadKey();
}

// Define other methods and classes here
public static void ThreadMethod()
{
 	for (int i = 0; i < 10; i++)
 	{
 		string message = $"Thread prod: {i}.";
		message.Dump();
		Thread.Sleep(0);
 	}
}