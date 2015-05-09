using System;

namespace State
{
    public class Beginner : Level
    {
        public Beginner(CounterStrike counterStrike)
        {
            CurrentPoints = 0;
            Cs = counterStrike;
            Initialize();
        }

        private void Initialize()
        {
            LowLimit = 0;
            HighLimit = 100;
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
            if (CurrentPoints > HighLimit)
            {
                Cs.Skill = new Intermediate(this);
            }
        }
    }
}
