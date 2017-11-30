using System;
using System.IO;
using System.Threading;

namespace Singleton
{
    public class Logger
    {
        private static Logger _instance = null;
        private static readonly object Padlock = new object();

        private const string File = "SingletonThreadSafe.log";
        private readonly bool _executedOnce = false;

        private Logger()
        {
            if (!_executedOnce)
                _executedOnce = true;
            else
                throw new Exception("You can not be here !");

            Console.WriteLine("--> Private constructor: should be executed once !");
        }

        public static Logger Instance
        {
            get
            {
                lock (Padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                        Console.WriteLine("Creates the instance");
                    }
                    return _instance;
                }
            }
        }

        public void Write(object content)
        {
            content = (string)content;

            var currentThreadId = string.Format($"Current thread Id used: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine(currentThreadId);

            // lock keyword is used to prevent thread concurrency exception
            lock (Padlock)
            {
                using (var writer = new StreamWriter(File, true))
                {
                    var currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.WriteLine(string.Concat("[" + currentDate + "] " + content, " - ", currentThreadId));
                }
            }
        }
    }
}