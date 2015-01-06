using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CuisinierBigMac : Cuisinier
    {
        public override void AjouterSteakHachés()
        {
            hamburger.NbSteackHaché(2);
        }

        public override void AjouterTrancheFromage()
        {
            hamburger.NbTrancheFromage(1);
        }

        public override void AjouterSauce()
        {
            hamburger.Sauce(true);
        }

        public override void AjouterSalade()
        {
            hamburger.Salade(true);
        }

        public override void AjouterCornichon()
        {
            hamburger.Cornichon(true);
        }
    }
}
