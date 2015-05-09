using System;

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