using System;

namespace Facade
{
    public class TachometerController : ITachometerController
    {
        private int _rpm;

        public int Rpm
        {
            get { return _rpm; }
            set
            {
                _rpm = value;
                Console.WriteLine("RPM: {0}", _rpm);
            }
        }

        public int Limit { get; private set; }

        public TachometerController()
        {
            Limit = 6000;
        }
    }
}
