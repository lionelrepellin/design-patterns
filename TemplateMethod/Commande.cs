using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Commande
    {
        protected double montantHT;
        protected double montantTVA;
        protected double montantTTC;

        /// <summary>
        /// Méthode spécialisée dans les classes
        /// qui héritent de Commande
        /// </summary>
        protected abstract void CalculTVA();

        public void CalculTTC()
        {
            this.CalculTVA();
            this.montantTTC = this.montantHT + this.montantTVA;
        }

        public void SetMontantHT(double montantHT)
        {
            this.montantHT = montantHT;
        }

        public void Affiche()
        {
            Console.WriteLine("[{0}]", this.GetType().FullName);
            Console.WriteLine("Montant HT: {0} Euros", this.montantHT);
            Console.WriteLine("Montant TTC: {0} Euros", this.montantTTC);
            Console.WriteLine();
        }
    }
}
