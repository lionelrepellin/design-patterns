using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private static Logger _instance = null;
        private static readonly object _padlock = new object();

        private string file = "SingletonThreadSafe.log";
        private bool _executedOnce = false;

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
                lock (_padlock)
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

            var currentThreadId = string.Format("Current thread Id used: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(currentThreadId);

            // lock keyword is used to prevent thread concurrency exception
            lock (_padlock)
            {
                using (var writer = new StreamWriter(file, true))
                {
                    var currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    writer.WriteLine(string.Concat("[" + currentDate + "] " + content, " - ", currentThreadId));
                }
            }
        }
    }
}
