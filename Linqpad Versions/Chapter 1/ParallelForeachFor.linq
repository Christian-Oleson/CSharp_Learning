<Query Kind="Statements">
  <Connection>
    <ID>1755be53-c5f9-4861-91df-85391f25fbc3</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <Server>localhost</Server>
    <UserName>postgres</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAx/hHpzj+6EayKfjPS6k9BgAAAAACAAAAAAADZgAAwAAAABAAAAAaACUyAkF8qLXUEpp/9ekiAAAAAASAAACgAAAAEAAAAJv20UgZMUlpZO4fcf/G8pkoAAAA/g4+Qs1FwS8+Jsahb3u+Gw7/P1wTv6DEx9EmLPsM5dqzMVuF02COGhQAAAD9XKwlwM9hXk7fAodtKpboDPubLA==</Password>
    <Database>ZendeskSync</Database>
    <DisplayName>Local_ZD_Sync</DisplayName>
    <DriverData>
      <EFProvider>Npgsql.EntityFrameworkCore.PostgreSQL</EFProvider>
      <UseNativeScaffolder>True</UseNativeScaffolder>
    </DriverData>
  </Connection>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Parallel.For(0, 1000, i =>
{
	Console.WriteLine(i);
	Thread.Sleep(1000);
});

var numbers = Enumerable.Range(0, 1000);
Parallel.ForEach(numbers, i =>
{
	Console.WriteLine(i);
	Thread.Sleep(1000);
});