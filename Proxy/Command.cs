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
            Console.WriteLine("Je monte les volets...");
        }

        public void Down()
        {
            Console.WriteLine("Je descends les volets...");
        }
    }
}
