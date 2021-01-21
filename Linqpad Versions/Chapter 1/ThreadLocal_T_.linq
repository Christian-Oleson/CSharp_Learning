<Query Kind="Program" />

void Main()
{
	new Thread(() => 
	{
		for(int x = 0; x < _field.Value; x++)
		{
			$"Thread A: {x}".Dump();
		}
	}).Start();
	new Thread(() =>
	{
		for (int x = 0; x < _field.Value; x++)
		{
			$"Thread B: {x}".Dump();
		}
	}).Start();
}

// You can define other methods, fields, classes and namespaces here
public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
{
	return Thread.CurrentThread.ManagedThreadId;
});