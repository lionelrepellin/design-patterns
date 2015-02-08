using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {        
        // set the value to False to change the behaviour
        private static bool _isUserAuthenticated = true;

        static void Main(string[] args)
        {
            var strategy = CreateBackupStrategy(_isUserAuthenticated);

            var service = new BackupService(strategy);

            // load data
            Console.WriteLine();
            service.Load();

            // save data
            Console.WriteLine();
            service.Save();
            
            Console.Read();
        }
        
        // instantiate the right strategy
        private static IBackupStrategy CreateBackupStrategy(bool userAuthenticated)
        {
            if (userAuthenticated)
            {
                return new UserAuthenticatedStrategy();
            }
            else
            {
                return new UserNotAuthenticatedStrategy();
            }
        }
    }
}
