using System;

namespace Facade
{
    public class TransmissionController : ITransmissionController
    {
        public int Gear { get; set; }
        public int MaxGear { get; set; }

        public TransmissionController()
        {
            MaxGear = 6;
        }

        public void ShiftUp()
        {
            if (Gear < MaxGear)
            {
                Gear++;
                Console.WriteLine(string.Format("Shifted up to gear {0}", Gear));
            }
        }

        public void ShiftDown()
        {
            if (Gear > 0)
            {
                Gear--;
                Console.WriteLine(string.Format("Shifted down to gear {0}", Gear));
            }
        }
    }
}
