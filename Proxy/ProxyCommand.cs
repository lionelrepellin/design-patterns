using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyCommand : IRollingShuttersCommand
    {
        private Anemometer _anemometer;
        private Command _command;        

        public ProxyCommand(Anemometer anemometer)
        {
            _anemometer = anemometer;
            _command = new Command();
        }

        public void Up()
        {
            if (_anemometer.IsWindSpeedAcceptable())
            {
                _command.Up();
            }
            else
            {
                Error();
            }
        }

        public void Down()
        {
            if (_anemometer.IsWindSpeedAcceptable())
            {
                _command.Down();
            }
            else
            {
                Error();
            }
        }

        private void Error()
        {
            Console.WriteLine("The wind speed is not appropriate for this action.");
            Console.WriteLine("Wind speed limit: {0} km/h", _anemometer.WindSpeedLimit);
            Console.WriteLine("Current wind speed: {0} km/h", _anemometer.CurrentWindSpeed);            
        }
    }
}
