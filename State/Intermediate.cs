namespace State
{
    public class Intermediate : Level
    {
        public Intermediate(Level level)
        {
            CurrentPoints = level.CurrentPoints;
            CounterStrike = level.CounterStrike;
            Initialize();
        }

        private void Initialize()
        {
            LowLimit = 100;
            HighLimit = 200;
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
            if (CurrentPoints < LowLimit)
            {
                CounterStrike.Skill = new Beginner(CounterStrike);
            }
            else if (CurrentPoints > HighLimit)
            {
                CounterStrike.Skill = new Expert(this);
            }
        }
    }
}
