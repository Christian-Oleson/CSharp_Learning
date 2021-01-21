using System;
using System.Threading;
using System.Threading.Tasks;

namespace WaitAny
{
    class Program
    {
        static void Main()
        {
            var tasks = new Task[4];

            tasks[0] = Task.Run(() => { Thread.Sleep(1000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(1000); return 3; });
            tasks[3] = Task.Run(() => { Thread.Sleep(1000); return 4; });

            while (tasks.Length > 0)
            {
                int i = Task.WaitAny(tasks);
                var completedTask = tasks[i];

                Console.WriteLine(completedTask.Res);
            }
        }
    }
}
