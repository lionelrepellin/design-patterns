using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Commande
    {
        protected double MontantHT;
        protected double MontantTVA;
        protected double MontantTTC;

        /// <summary>
        /// Méthode spécialisée dans les classes
        /// qui héritent de Commande
        /// </summary>
        protected abstract void CalculTVA();

        public void CalculTTC()
        {
            CalculTVA();
            MontantTTC = MontantHT + MontantTVA;
        }

        public void SetMontantHT(double montantHT)
        {
            MontantHT = montantHT;
        }

        public void Affiche()
        {
            Console.WriteLine("[{0}]", this.GetType().FullName);
            Console.WriteLine("Montant HT: {0} Euros", MontantHT);
            Console.WriteLine("Montant TTC: {0} Euros", MontantTTC);
            Console.WriteLine();
        }
    }
}
