using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// Utilisateur authentifié
    /// </summary>
    public class UserAuthenticatedStrategy : IBackupStrategy
    {
        public void Save()
        {
            Console.WriteLine("[{0}] on sauvegarde en base de données", this.GetType().Name);
        }

        public object Load()
        {
            Console.WriteLine("[{0}] on charge les données depuis la base de données", this.GetType().Name);
            return new object();
        }
    }
}
