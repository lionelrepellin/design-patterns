using System;

namespace Strategy
{
    // user is not authenticated
    public class UserNotAuthenticatedStrategy : IBackupStrategy
    {
        public object Load()
        {
            Console.WriteLine("[{0}] Load data from an XML file", GetType().Name);
            return new object();
        }

        public void Save()
        {
            Console.WriteLine("[{0}] Save data into an XML file", GetType().Name);
        }
    }
}
