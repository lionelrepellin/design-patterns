using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Serveur
    {
        private Cuisinier cuisinier;

        public void ChoisirCuisinier(Cuisinier cuisinier)
        {
            this.cuisinier = cuisinier;
        }

        public Hamburger DonnerHamburger()
        {
            return this.cuisinier.DonnerHamburger();
        }

        public void LancerLaPreparation()
        {
            this.cuisinier.CréerHamburger();
            this.cuisinier.AjouterSalade();
            this.cuisinier.AjouterSteakHachés();
            this.cuisinier.AjouterTrancheFromage();
            this.cuisinier.AjouterSauce();
            this.cuisinier.AjouterCornichon();
        }
    }
}
