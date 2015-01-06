using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Hamburger
    {
        private int nbSteackHachés;
        private int nbTrancheFromage;
        private bool sauce;
        private bool salade;
        private bool cornichon;

        public void NbSteackHaché(int nbSteackHachés)
        {
            this.nbSteackHachés = nbSteackHachés;
        }

        public void NbTrancheFromage(int nbTrancheFromage)
        {
            this.nbTrancheFromage = nbTrancheFromage;
        }

        public void Sauce(bool sauce)
        {
            this.sauce = sauce;
        }

        public void Salade(bool salade)
        {
            this.salade = salade;
        }

        public void Cornichon(bool cornichon)
        {
            this.cornichon = cornichon;
        }

        public override string ToString()
        {
            var sauceExists = (this.sauce) ? "avec de la sauce" : "sans sauce";
            var saladeExists = (this.salade) ? "avec de la salade" : "sans salade";
            var cornichonExists = (this.cornichon) ? "avec une tranche de cornichon" : "sans cornichon";

            return string.Format("Le burger est constitué de {0} steack(s) haché(s), avec {1} tranche(s) de fromage, {2}, {3} et {4}.", this.nbSteackHachés, this.nbTrancheFromage, sauceExists, saladeExists, cornichonExists);
        }
    }
}
