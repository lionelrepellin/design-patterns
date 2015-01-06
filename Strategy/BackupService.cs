using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// Le service de sauvegarde. La comportement de la sauvegarde
    /// sera différent en fonction de la stratégie définit.
    /// </summary>
    public class BackupService
    {
        private IBackupStrategy _strategy;

        public BackupService(IBackupStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Save()
        {
            _strategy.Save();
        }

        public object Load()
        {
            return _strategy.Load();
        }
    }
}