using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // user is authenticated
    public class UserAuthenticatedStrategy : IBackupStrategy
    {
        public object Load()
        {            
            Console.WriteLine("[{0}] Load data from the database", this.GetType().Name);
            return new object();
        }

        public void Save()
        {
            Console.WriteLine("[{0}] Save data into the database", this.GetType().Name);
        }
    }
}
