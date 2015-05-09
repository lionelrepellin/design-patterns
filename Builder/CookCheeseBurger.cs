namespace Builder
{
    public class CookCheeseBurger : Cook
    {
        public override void AddSteak()
        {
            Hamburger.Steak(1);
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
            Hamburger.Salad(false);
        }

        public override void AddGherkin()
        {
            Hamburger.Gherkin(true);
        }
    }
}