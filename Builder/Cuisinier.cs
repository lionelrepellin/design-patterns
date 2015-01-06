using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Cuisinier
    {
        protected Hamburger hamburger;

        public void CréerHamburger()
        {
            hamburger = new Hamburger();
        }

        public Hamburger DonnerHamburger()
        {
            return hamburger;
        }

        public abstract void AjouterSteakHachés();
        public abstract void AjouterTrancheFromage();
        public abstract void AjouterSauce();
        public abstract void AjouterSalade();
        public abstract void AjouterCornichon();
    }
}
