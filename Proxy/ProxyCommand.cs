using System;

namespace Proxy
{
    public class ProxyCommand : IRollingShuttersCommand
    {
        private readonly Anemometer _anemometer;
        private readonly Command _command;        

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
                Error("Up");
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
                Error("Down");
            }
        }

        private void Error(string actionName)
        {
            Console.WriteLine($"The wind speed is not appropriate for the '{actionName}' action.");
            Console.WriteLine($"Wind speed limit: {_anemometer.WindSpeedLimit} km/h");
            Console.WriteLine($"Current wind speed: {_anemometer.CurrentWindSpeed} km/h");            
        }
    }
}
