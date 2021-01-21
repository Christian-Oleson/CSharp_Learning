<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var t = Task<int>.Run(() => 
{
	return 42;
}).ContinueWith((i) => 
{
	return i.Result * 2;
});

t.Result.Dump();