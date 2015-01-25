using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Un patron de méthode définit le squelette d'un algorithme à l'aide d'opérations abstraites 
 * dont le comportement concret se trouvera dans les sous-classes, qui implémenteront ces opérations.
 */
namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // montant HT
            var amountDutyFree = 100;

            var orderFromFrance = new OrderFromFrance();
            orderFromFrance.AmountDutyFree(amountDutyFree);

            // calcul le montant TTC en fonction de la TVA du pays
            orderFromFrance.AllTaxesIncludedCalculation();

            // affiche le résultat
            orderFromFrance.Display();

            Console.WriteLine("--------------------\r\n");

            var orderFromLux = new OrderFromLuxembourg();
            orderFromLux.AmountDutyFree(amountDutyFree);
            orderFromLux.AllTaxesIncludedCalculation();
            orderFromLux.Display();

            Console.WriteLine("--------------------\r\n");

            var orderFromMalte = new OrderFromMalte();
            orderFromMalte.AmountDutyFree(amountDutyFree);
            orderFromMalte.AllTaxesIncludedCalculation();
            orderFromMalte.Display();

            Console.WriteLine("--------------------\r\n");

            var orderFromHongrie = new OrderFromHongrie();
            orderFromHongrie.AmountDutyFree(amountDutyFree);
            orderFromHongrie.AllTaxesIncludedCalculation();
            orderFromHongrie.Display();

            Console.Read();
        }
    }
}
