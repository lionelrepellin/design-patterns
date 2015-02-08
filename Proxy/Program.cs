using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // change wind speed over 35 km/h
            // and you will not be able to up/down the rolling shutters
            var windSpeed = 30;
            var anemometer = new Anemometer(windSpeed);

            var proxy = new ProxyCommand(anemometer);

            // try to up/down the rolling shutters
            proxy.Up();

            Console.WriteLine();

            proxy.Down();

            Console.Read();
        }
    }
}
