<Query Kind="Program" />

void Main()
{
	int s = 5;
	var ts = new ParameterizedThreadStart(ThreadMethod);
	var t = new Thread(ts);
	t.Start(s);
	
	for(int i = 0; i < 4; i++)
	{
		string m = $"Main thread is doing some work...";
		m.Dump();
		Thread.Sleep(0);
	}
}

// Define other methods and classes here
public static void ThreadMethod(object o)
{
 	for (int i = 0; i < 10; i++)
 	{
 		string message = $"Thread prod: {i}. The object passed is {o}";
		message.Dump();
		Thread.Sleep(0);
 	}
}