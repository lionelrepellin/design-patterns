using System;
using System.Collections.Generic;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var threads = new List<Thread>();
            const int NumberOfThreads = 50;

            // starts all the threads
            for (var i = 0; i < NumberOfThreads; i++)
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