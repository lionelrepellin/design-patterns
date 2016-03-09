namespace State
{
    public class Expert : Level
    {
        public Expert(Level level)
        {
            CurrentPoints = level.CurrentPoints;
            CounterStrike = level.CounterStrike;
            Initialize();
        }

        private void Initialize()
        {
            LowLimit = 200;
            HighLimit = 300;
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
                CounterStrike.Skill = new Intermediate(this);
            }            
        }
    }
}
