<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var tasks = new Task[3];

tasks[0] = Task.Run(() =>
{
	Thread.Sleep(1000);
	1.Dump();
	return 1;
});

tasks[1] = Task.Run(() =>
{
	Thread.Sleep(1000);
	2.Dump();
	return 2;
});

tasks[2] = Task.Run(() =>
{
	Thread.Sleep(1000);
	3.Dump();
	return 3;
});

Task.WaitAll(tasks);