using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Command : IRollingShuttersCommand
    {
        public void Up()
        {
            Console.WriteLine("I go up the rolling shutters.");
        }

        public void Down()
        {
            Console.WriteLine("I go down the rolling shutters.");
        }
    }
}
