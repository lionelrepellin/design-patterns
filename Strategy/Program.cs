using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Le patron de conception stratégie est utile pour des situations où il est nécessaire 
 * de permuter dynamiquement les algorithmes utilisés dans une application.
 */
namespace Strategy
{
    class Program
    {
        /// <summary>
        /// Modifier la valeur pour changer de stratégie
        /// </summary>
        private static bool _isUserAuthenticated = true;

        static void Main(string[] args)
        {
            var strategy = CreateBackupStrategy(_isUserAuthenticated);

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
