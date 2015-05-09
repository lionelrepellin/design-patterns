using System;

namespace TemplateMethod
{
    public abstract class Order
    {
        // HT in French
        protected double ExcludingTaxes; // ET

        // TVA in French
        protected double Vat; // VAT

        // TTC in French
        protected double AllTaxesIncluded; // ATI

        // this method is specialized into classes who inherits from this class
        protected abstract void VatCalculation();
                
        // method calculation is the same for each country
        // only the amount of VAT of each country gives a different ATI amount
        public void AllTaxesIncludedCalculation()
        {
            // the VAT amount is calculated in each concrete class
            VatCalculation();
            
            // ATI = ET + VAT
            AllTaxesIncluded = ExcludingTaxes + Vat;
        }

        public void ExcludingTaxesAmount(double excludingTaxes)
        {
            ExcludingTaxes = excludingTaxes;
        }

        public void Display()
        {
            Console.WriteLine("[{0}]", this.GetType().FullName);
            Console.WriteLine("Excluding taxes amount: {0} Euros", ExcludingTaxes);
            Console.WriteLine("All taxes included amount: {0} Euros", AllTaxesIncluded);
            Console.WriteLine();
        }
    }
}