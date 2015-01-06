using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyCommand : IRollingShuttersCommand
    {
        private Anemometer anemometer;
        private Command command;
        private string errorMessage = "La vitesse du vent n'est pas appropriée pour cette action.";

        public ProxyCommand(Anemometer anemometer)
        {
            this.anemometer = anemometer;
            this.command = new Command();
        }

        public void Up()
        {
            if (anemometer.IsWindSpeedAcceptable())
            {
                this.command.Up();
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }

        public void Down()
        {
            if (anemometer.IsWindSpeedAcceptable())
            {
                this.command.Down();
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
}
