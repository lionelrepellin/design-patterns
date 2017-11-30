using System;
using System.Threading;
//
// Source: https://visualstudiomagazine.com/articles/2013/06/18/the-facade-pattern-in-net.aspx (Eric Vogel)
// with some personal improvements ;)
//
// The Facade pattern is a common software design pattern used to create a simple unified interface 
// for a set of interfaces in a system. The Facade interface is a higher-level interface that allows 
// easier control of a set of subsystem interfaces without affecting the subsystem interfaces.

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new VehicleFacade instance
            var vehicleFacade = new VehicleFacade
            (
                new EngineController(),
                new TransmissionController(),
                new TractionControlController(),
                new TachometerController()
            );

            // then start the vehicle
            vehicleFacade.Start();

            // then accelerate the vehicle from gear rest up to gear six
            for (int i = 0; i < 55; i++)
            {
                Thread.Sleep(100);
                vehicleFacade.Accelerate();
            }

            Console.WriteLine("{0}Vehicle is running too fast...{0}Now slow down a little bit...{0}", Environment.NewLine);

            for (var i = 0; i < 4; i++)
            {
                vehicleFacade.SlowDown();
                Thread.Sleep(100);
            }

            Console.WriteLine("{0}So brake until the vehicle stops !{0}", Environment.NewLine);

            vehicleFacade.BrakeUntilItStops();
            
            // turn off the vehicle
            vehicleFacade.Off();

            Console.Read();
        }
    }
}
