namespace Builder
{
    public class CookBigMac : Cook
    {
        public override void AddSteak()
        {
            Hamburger.Steak(2);
        }

        public override void AddCheese()
        {
            Hamburger.SliceOfCheese(1);
        }

        public override void AddSauce()
        {
            Hamburger.Sauce(true);
        }

        public override void AddSalad()
        {
            Hamburger.Salad(true);
        }

        public override void AddGherkin()
        {
            Hamburger.Gherkin(true);
        }
    }
}