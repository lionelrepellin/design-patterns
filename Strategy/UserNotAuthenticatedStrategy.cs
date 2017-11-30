using System;

namespace Strategy
{
    // user is not authenticated
    public class UserNotAuthenticatedStrategy : IBackupStrategy
    {
        public object Load()
        {
            Console.WriteLine($"[{GetType().Name}] Load data from an XML file");
            return new object();
        }

        public void Save()
        {
            Console.WriteLine($"[{GetType().Name}] Save data into an XML file");
        }
    }
}
