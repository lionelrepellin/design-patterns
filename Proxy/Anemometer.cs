using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Anemometer
    {
        private int _windSpeed;
        private const int _windSpeedLimit = 35;

        public int WindSpeedLimit
        {
            get
            {
                return _windSpeedLimit;
            }
        }

        public int CurrentWindSpeed
        {
            get
            {
                return _windSpeed;
            }
        }

        public Anemometer(int speed)
        {
            _windSpeed = speed;
        }

        public bool IsWindSpeedAcceptable()
        {
            return _windSpeed <= _windSpeedLimit;
        }
    }
}
