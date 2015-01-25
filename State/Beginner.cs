using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Beginner : Level
    {
        public Beginner(CounterStrike counterStrike)
        {
            this.CurrentPoints = 0;
            this.CS = counterStrike;
            Initialize();
        }

        private void Initialize()
        {
            this.LowLimit = 0;
            this.HighLimit = 100;
        }

        public override void WinPoints(int points)
        {
            this.CurrentPoints += points;
            CheckLevel();
        }

        public override void LoosePoints(int points)
        {
            Console.WriteLine("Looser level does not exist yet !");
        }

        private void CheckLevel()
        {
            if (this.CurrentPoints > this.HighLimit)
            {
                this.CS.Skill = new Intermediate(this);
            }
        }
    }
}
