using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;

namespace Asynchronic
{
    class Program
    {
        static void Main(string[] args)
        {
            //run in Release model without debugging - otherwise won't work
            //var summary = BenchmarkRunner.Run<BenchmarkTest>();

            WaitAll();
            WaitAny();

            var cts = new CancellationTokenSource(5000);
            LinkedCancellationTokenTest(cts.Token);

            ConcurrentCollectionTest();

            Console.ReadKey();
        }

        private static void WaitAll()
        {
            Console.WriteLine("WaitAll stared");
            var cts = new CancellationTokenSource(2000);

            const int size = 4;

            var tasks = new Task<double>[size];

            for (var i = 0; i < size; i++)
            {
                var tempI = i;
                var task = new Task<double>(() => Math.Sqrt(tempI), cts.Token);
                task.Start();
                Debug($"Task {i} started");
                tasks[i] = task;
            }

            Task.WaitAll(tasks, 2000, cts.Token);

            Console.WriteLine($"a={tasks[0].Result:N3} / b={tasks[1].Result:N3} / c={tasks[2].Result:N3} / d={tasks[3].Result:N3}");
            Console.WriteLine("WaitAll ended");
        }

        private static void WaitAny()
        {
            Console.WriteLine("WaitAny started");

            var cts = new CancellationTokenSource(2000);

            const int size = 4;

            var tasks = new Task<double>[size];

            for (var i = 0; i < size; i++)
            {
                var tempI = i;
                var task = new Task<double>(() =>
                {

                    Debug($"Task{tempI} started");
                    return Math.Sqrt(tempI);
                }, cts.Token);

                task.Start();

                tasks[i] = task;
            }

            var index = Task.WaitAny(tasks);
            Debug($"Task {index} finished first");

            cts.Cancel();
            for (var i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine($"Task {i} status: {tasks[i].Status}");
            }

            Console.WriteLine("WaitAny ended");
        }

        static void LinkedCancellationTokenTest(CancellationToken token)
        {
            Console.WriteLine("Linked started");
            var cts = new CancellationTokenSource(1000);

            var linkTs = CancellationTokenSource.CreateLinkedTokenSource(token, cts.Token);

            var task = Task.Run(() => Math.Asin(1), linkTs.Token);

            Console.WriteLine($"arcsin(1) = pi/2 ~= {task.Result}");
            Console.WriteLine("Linked ended");

        }

        static void ConcurrentCollectionTest()
        {
            Debug("ConcurrentCollectionTest Start");
            const int size = 10;
            var stack = new ConcurrentStack<int>();
            var cts = new CancellationTokenSource(1 * 1000);

            var tasks = Enumerable.Range(0, size).Select(x => Task.Run(() =>
            {
                var tempId = x;
                while (!cts.IsCancellationRequested)
                {
                    if (tempId % 2 != 0)
                    {
                        stack.Push(tempId);
                        Debug($"Task {tempId} Push on stack");
                    }
                    else
                    {
                        int result = -1;
                        if (stack.TryPop(out result))
                        {
                            Debug($"Task {tempId} TryPop {result}");
                        }
                        else
                        {
                            Debug($"Task {tempId} TryPop failed");
                        }
                    }

                    Thread.Sleep(100);
                }

                Debug($"Task {tempId} cancelled");
            }, cts.Token)).ToList();

            //while (!cts.IsCancellationRequested) { }

            Debug($"Cancelled, stack: {string.Join(", ", stack.ToArray())}");
            Debug("ConcurrentCollectionTest End");
        }

        static void Debug<T>(T arg) =>
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {arg}");
    }
}
