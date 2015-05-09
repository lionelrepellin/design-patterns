using System;

namespace Strategy
{
    // user is authenticated
    public class UserAuthenticatedStrategy : IBackupStrategy
    {
        public object Load()
        {            
            Console.WriteLine("[{0}] Load data from the database", GetType().Name);
            return new object();
        }

        public void Save()
        {
            Console.WriteLine("[{0}] Save data into the database", GetType().Name);
        }
    }
}
