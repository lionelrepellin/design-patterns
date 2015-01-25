using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var sauceExists = (_sauce) ? "avec de la sauce" : "sans sauce";
            var saladExists = (_salad) ? "avec de la salade" : "sans salade";
            var gherkinExists = (_gherkin) ? "avec une tranche de cornichon" : "sans cornichon";

            return string.Format("Le burger est constitué de {0} steack(s), avec {1} tranche(s) de fromage, {2}, {3} et {4}.", _nbSteack, _nbSliceOfCheese, sauceExists, saladExists, gherkinExists);
        }
    }
}
