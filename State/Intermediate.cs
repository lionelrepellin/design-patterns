using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Intermediate : Level
    {
        public Intermediate(Level level)
        {
            this.CurrentPoints = level.CurrentPoints;
            this.CS = level.CS;
            Initialize();
        }

        private void Initialize()
        {
            this.LowLimit = 100;
            this.HighLimit = 200;
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
                this.CS.Skill = new Beginner(this.CS);
            }
            else if (this.CurrentPoints > this.HighLimit)
            {
                this.CS.Skill = new Expert(this);
            }
        }
    }
}
