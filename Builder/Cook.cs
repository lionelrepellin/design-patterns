namespace Builder
{
    public abstract class Cook
    {
        protected Hamburger Hamburger;

        public void CreateHamburger()
        {
            Hamburger = new Hamburger();
        }

        public Hamburger GiveHamburger()
        {
            return Hamburger;
        }

        public abstract void AddSteak();
        public abstract void AddCheese();
        public abstract void AddSauce();
        public abstract void AddSalad();
        public abstract void AddGherkin();
    }
}