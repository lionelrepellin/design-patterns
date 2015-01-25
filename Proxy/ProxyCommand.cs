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
        private string _errorMessage = "La vitesse du vent n'est pas appropriée pour cette action.";

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
                Console.WriteLine(_errorMessage);
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
                Console.WriteLine(_errorMessage);
            }
        }
    }
}
