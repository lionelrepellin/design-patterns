namespace State
{
    public class Intermediate : Level
    {
        public Intermediate(Level level)
        {
            CurrentPoints = level.CurrentPoints;
            Cs = level.Cs;
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
                Cs.Skill = new Beginner(Cs);
            }
            else if (CurrentPoints > HighLimit)
            {
                Cs.Skill = new Expert(this);
            }
        }
    }
}
