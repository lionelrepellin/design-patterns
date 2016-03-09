using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public interface IEngineController
    {
        bool Running { get; }
        void Start();
        void Stop();
    }
}
