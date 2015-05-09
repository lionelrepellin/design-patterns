namespace Proxy
{
    public class Anemometer
    {
        private readonly int _windSpeed;
        private const int _windSpeedLimit = 35;

        public int WindSpeedLimit
        {
            get
            {
                return _windSpeedLimit;
            }
        }

        public int CurrentWindSpeed
        {
            get
            {
                return _windSpeed;
            }
        }

        public Anemometer(int speed)
        {
            _windSpeed = speed;
        }

        public bool IsWindSpeedAcceptable()
        {
            return _windSpeed <= _windSpeedLimit;
        }
    }
}