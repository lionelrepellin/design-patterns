using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    public abstract class Level
    {
        protected double LowLimit;
        protected double HighLimit;

        // Properties
        public CounterStrike CS { get; set; }
        public int CurrentPoints { get; set; }

        public abstract void WinPoints(int points);
        public abstract void LoosePoints(int points);
    }
}
