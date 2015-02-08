using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var threads = new List<Thread>();
            var numberOfThreads = 50;

            // starts all the threads
            for (var i = 0; i < numberOfThreads; i++)
            {
                var thread = new Thread(new ParameterizedThreadStart(Logger.Instance.Write));
                thread.Start(string.Format("Thread number: {0}", i));

                threads.Add(thread);
            }

            // waits all the threads before ending
            foreach (var thread in threads)
            {
                thread.Join();
            }

            Console.Read();
        }
    }
}