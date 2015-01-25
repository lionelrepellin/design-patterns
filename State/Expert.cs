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
            this.LowLimit = 200;
            this.HighLimit = 300;
        }

        public override void WinPoints(int points)
        {
            this.CurrentPoints += points;
            CheckLevel();
        }

        public override void LoosePoints(int points)
        {
            this.CurrentPoints -= points;
            CheckLevel();
        }

        private void CheckLevel()
        {
            if (this.CurrentPoints < this.LowLimit)
            {
                this.CS.Skill = new Intermediate(this);
            }            
        }
    }
}
