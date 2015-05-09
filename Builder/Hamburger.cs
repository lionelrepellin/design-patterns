namespace Builder
{
    public class Hamburger
    {
        private int _nbSteack;
        private int _nbSliceOfCheese;
        private bool _sauce;
        private bool _salad;
        private bool _gherkin;

        public void Steak(int nbSteack)
        {
            _nbSteack = nbSteack;
        }

        public void SliceOfCheese(int nbSliceOfCheese)
        {
            _nbSliceOfCheese = nbSliceOfCheese;
        }

        public void Sauce(bool sauce)
        {
            _sauce = sauce;
        }

        public void Salad(bool salad)
        {
            _salad = salad;
        }

        public void Gherkin(bool gherkin)
        {
            _gherkin = gherkin;
        }

        public override string ToString()
        {
            var sauceExists = (_sauce) ? "with sauce" : "without sauce";
            var saladExists = (_salad) ? "with salad" : "without salad";
            var gherkinExists = (_gherkin) ? "with a gherkin" : "without gherkin";

            return string.Format("The burger is made with {0} steack, with {1} slice of cheese, {2}, {3} and {4}.", _nbSteack, _nbSliceOfCheese, sauceExists, saladExists, gherkinExists);
        }
    }
}