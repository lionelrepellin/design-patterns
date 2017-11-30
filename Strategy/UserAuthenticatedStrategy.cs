using System;

namespace Strategy
{
    // user is authenticated
    public class UserAuthenticatedStrategy : IBackupStrategy
    {
        public object Load()
        {            
            Console.WriteLine($"[{GetType().Name}] Load data from the database");
            return new object();
        }

        public void Save()
        {
            Console.WriteLine($"[{GetType().Name}] Save data into the database");
        }
    }
}
