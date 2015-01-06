using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// Utilisateur non authentifié
    /// </summary>
    public class UserNotAuthenticatedStrategy : IBackupStrategy
    {
        public void Save()
        {
            Console.WriteLine("[{0}] on sauvegarde dans un fichier XML", this.GetType().Name);
        }

        public object Load()
        {
            Console.WriteLine("[{0}] on lit les données depuis un fichier XML", this.GetType().Name);
            return new object();
        }
    }
}
