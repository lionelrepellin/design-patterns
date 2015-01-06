using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        /// <summary>
        /// Modifier la valeur pour changer de stratégie
        /// </summary>
        private static bool isUserAuthenticated = true;

        static void Main(string[] args)
        {
            var strategy = CreateBackupStrategy(isUserAuthenticated);

            var service = new BackupService(strategy);
            service.Load();
            service.Save();

            Console.Read();
        }

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
