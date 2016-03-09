using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public interface IVehicleFacade
    {
        void Start();
        void Accelerate();
        void SlowDown();
        void BrakeUntilItStops();
        void Off();
    }
}
