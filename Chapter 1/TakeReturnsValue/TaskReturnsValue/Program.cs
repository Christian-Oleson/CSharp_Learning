using System;
using System.Threading.Tasks;

namespace TaskReturnsValue
{
    class Program
    {
        static void Main()
        {
            var t = Task<int>.Run(() =>
            {
                return 42;
            });

            Console.WriteLine(t.Result);
        }
    }
}
