using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Expert : Level
    {
        public Expert(Level level)
        {
            this.CurrentPoints = level.CurrentPoints;
            this.CS = level.CS;
            Initialize();
        }

        private void Initialize()
        {
            lowLimit = 200;
            highLimit = 300;
        }

        public override void WinPoints(int points)
        {
            CurrentPoints += points;
            CheckLevel();
        }

        public override void LoosePoints(int points)
        {
            CurrentPoints -= points;
            CheckLevel();
        }

        private void CheckLevel()
        {
            if (CurrentPoints < lowLimit)
            {
                CS.Skill = new Intermediate(this);
            }            
        }
    }
}
