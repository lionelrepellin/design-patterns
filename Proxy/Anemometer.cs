using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Anemometer
    {
        private int windSpeed;
        private const int windSpeedLimit = 35;

        public Anemometer(int speed)
        {
            this.windSpeed = speed;
        }

        public bool IsWindSpeedAcceptable()
        {
            return windSpeed <= windSpeedLimit;
        }
    }
}
