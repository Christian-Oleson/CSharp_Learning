<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var t = Task<int>.Run(() =>
{
	return 42;
});

Console.WriteLine(t.Result);