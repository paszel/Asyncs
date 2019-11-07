using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Asynchronic
{
    [MemoryDiagnoser]
    public class BenchmarkTest
    {
        [Benchmark]
        public int PlaneUsage()
        {
            return TwoPlusTwo();
        }

        [Benchmark]
        public int ExecuteOnThreadPool()
        {
            var autoEvent = new AutoResetEvent(false);
            var result = 0;

            ThreadPool.QueueUserWorkItem(x =>
            {
                result = TwoPlusTwo();
                autoEvent.Set();
            });


            autoEvent.WaitOne(2000);
            autoEvent.Close();

            return result;
        }

        [Benchmark]
        public int ExecuteOnTask()
        {
            var result = 0;
            var task = new Task(() => { result = TwoPlusTwo(); });
            task.Start();
            task.Wait(2000);
            return result;
        }

        [Benchmark]
        public int ExecuteOnThread()
        {
            var autoEvent = new AutoResetEvent(false);
            var result = 0;

            var thread = new Thread(() =>
            {
                result = TwoPlusTwo();
                autoEvent.Set();
            });

            thread.Start();
            autoEvent.WaitOne(2000);
            autoEvent.Close();
            return result;
        }

        private static int TwoPlusTwo()
        {
            return 2 + 2;
        }
            }
}