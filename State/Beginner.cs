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
            lowLimit = 0;
            highLimit = 100;
        }

        public override void WinPoints(int points)
        {
            CurrentPoints += points;
            CheckLevel();
        }

        public override void LoosePoints(int points)
        {
            Console.WriteLine("Looser level does not exist yet !");
        }

        private void CheckLevel()
        {
            if (CurrentPoints > highLimit)
            {
                CS.Skill = new Intermediate(this);
            }
        }
    }
}
