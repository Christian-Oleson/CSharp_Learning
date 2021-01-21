<Query Kind="Program" />

void Main()
{
	new Thread(() =>
	{
		for (int i = 0; i < 10; i++)
		{
			_staticField++;
			Console.WriteLine($"Thread A: {_staticField}");
		}
	}).Start();

	new Thread(() =>
	{
		for (int i = 0; i < 10; i++)
		{
			_staticField++;
			Console.WriteLine($"Thread B: {_staticField}");
		}
	}).Start();
}

// You can define other methods, fields, classes and namespaces here
[ThreadStatic]
public static int _staticField;