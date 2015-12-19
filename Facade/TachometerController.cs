using System;

namespace Facade
{
    public interface ITachometerController
    {
        int Rpm { get; set; }
        int Limit { get; }
    }

    public class TachometerController : ITachometerController
    {
        private int rpm;

        public int Rpm
        {
            get { return rpm; }
            set
            {
                rpm = value;
                Console.WriteLine("RPM: {0}", rpm);
            }
        }

        public int Limit { get; private set; }

        public TachometerController()
        {
            Limit = 5000;
        }
    }
}
