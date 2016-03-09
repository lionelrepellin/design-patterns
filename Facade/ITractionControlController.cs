using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public interface ITractionControlController
    {
        bool Enabled { get; set; }
        void Enable();
        void Disable();
    }
}
