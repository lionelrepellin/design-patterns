namespace Builder
{
    public class MyBurger : Cook
    {
        public override void AddSteak()
        {
            Hamburger.Steak(3);
        }

        public override void AddCheese()
        {
            Hamburger.SliceOfCheese(2);
        }

        public override void AddSauce()
        {
            Hamburger.Sauce(true);
        }

        public override void AddSalad()
        {
            // it is not useful 
            Hamburger.Salad(false);
        }

        public override void AddGherkin()
        {
            // I hate this !
            Hamburger.Gherkin(false);
        }
    }
}