using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{    
    class Program
    {
        static void Main(string[] args)
        {
            var serveur = new Serveur();
            
            var cuisinierBigMac = new CuisinierBigMac();
            var cuisinierCheeseBurger = new CuisinierCheeseBurger();

            serveur.ChoisirCuisinier(cuisinierBigMac);
            //serveur.ChoisirCuisinier(cuisinierCheeseBurger);
            serveur.LancerLaPreparation();

            var hamburger = serveur.DonnerHamburger();

            Console.WriteLine(hamburger);
            Console.Read();
        }
    }
}
