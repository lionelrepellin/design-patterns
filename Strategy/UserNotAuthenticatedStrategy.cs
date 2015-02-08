using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // user is not authenticated
    public class UserNotAuthenticatedStrategy : IBackupStrategy
    {
        public object Load()
        {
            Console.WriteLine("[{0}] Load data from an XML file", this.GetType().Name);
            return new object();
        }

        public void Save()
        {
            Console.WriteLine("[{0}] Save data into an XML file", this.GetType().Name);
        }
    }
}
