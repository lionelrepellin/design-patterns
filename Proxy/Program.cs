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
            var windSpeed = 30;
            var anemometer = new Anemometer(windSpeed);

            var proxy = new ProxyCommand(anemometer);
            proxy.Up();
            proxy.Down();

            Console.Read();
        }
    }
}
