using System;
using System.Threading;

namespace ThreadStatic
{
    public static class Program
    {
        [ThreadStatic]
        public static int _staticField;

        static void Main()
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
    }
}
