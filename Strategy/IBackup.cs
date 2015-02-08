using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // the Load() and Save() methods will be used
    // regardless of the strategy
    public interface IBackupStrategy
    {
        object Load();

        void Save();
    }
}
