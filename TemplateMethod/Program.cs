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
            var montant = 100;

            var cmdeFrance = new CommandeFrance();
            cmdeFrance.SetMontantHT(montant);
            cmdeFrance.CalculTTC();
            cmdeFrance.Affiche();

            Console.WriteLine("--------------------\r\n");

            var cmdeLux = new CommandeLuxembourg();
            cmdeLux.SetMontantHT(montant);
            cmdeLux.CalculTTC();
            cmdeLux.Affiche();

            Console.WriteLine("--------------------\r\n");

            var cmdeMalte = new CommandeMalte();
            cmdeMalte.SetMontantHT(montant);
            cmdeMalte.CalculTTC();
            cmdeMalte.Affiche();

            Console.WriteLine("--------------------\r\n");

            var cmdeHongrie = new CommandeHongrie();
            cmdeHongrie.SetMontantHT(montant);
            cmdeHongrie.CalculTTC();
            cmdeHongrie.Affiche();

            Console.Read();
        }
    }
}
