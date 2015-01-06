using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    /// <summary>
    /// Les méthodes Save et Load seront utilisées, 
    /// peu importe la stratégie employée
    /// </summary>
    public interface IBackupStrategy
    {
        object Load();

        void Save();
    }
}
