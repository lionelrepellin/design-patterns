using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Order
    {
        protected double DutyFree;
        protected double TaxeAmount;
        protected double TaxesIncluded;

        /// <summary>
        /// Méthode spécialisée dans les classes
        /// qui héritent de Commande
        /// </summary>
        protected abstract void VatCalculation();

        /// <summary>
        /// La méthode de calcul est identique pour 
        /// tous les pays, seul le montant de la TVA
        /// propre à chacun donne un montant TTC différent
        /// </summary>
        public void AllTaxesIncludedCalculation()
        {
            // le montant de la TVA (TaxeAmount) est
            // calculé dans les classes concrètes
            VatCalculation();
            
            // TTC = HT + TVA
            TaxesIncluded = DutyFree + TaxeAmount;
        }

        public void AmountDutyFree(double amountDutyFree)
        {
            DutyFree = amountDutyFree;
        }

        public void Display()
        {
            Console.WriteLine("[{0}]", this.GetType().FullName);
            Console.WriteLine("Montant HT: {0} Euros", DutyFree);
            Console.WriteLine("Montant TTC: {0} Euros", TaxesIncluded);
            Console.WriteLine();
        }
    }
}
