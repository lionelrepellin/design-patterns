using System;

namespace Facade
{
    public class EngineController : IEngineController
    {
        public bool Running { get; private set; }

        public void Start()
        {
            Running = true;
            Console.WriteLine("Engine started");
        }

        public void Stop()
        {
            Running = false;
            Console.WriteLine("Engine stopped");
        }
    }
}
