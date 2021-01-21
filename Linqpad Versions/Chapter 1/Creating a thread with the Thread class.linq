<Query Kind="Program">
  <RuntimeVersion>5.0</RuntimeVersion>
</Query>

void Main()
{
	var ts = new ThreadStart(ThreadMethod);
	var t = new Thread(ts);
	t.Start();
	
	for(int i = 0; i < 4; i++)
	{
		string m = $"Main thread is doing some work...";
		m.Dump();
		Thread.Sleep(0);
	}
}

// Define other methods and classes here
public static void ThreadMethod()
{
 	for (int i = 0; i < 10; i++)
 	{
 		string message = $"Thread prod: {i}";
		message.Dump();
		Thread.Sleep(0);
 	}
}