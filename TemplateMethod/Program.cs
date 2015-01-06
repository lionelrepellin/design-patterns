using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmdeFrance = new CommandeFrance();
            cmdeFrance.SetMontantHT(100);
            cmdeFrance.CalculTTC();
            cmdeFrance.Affiche();

            Console.WriteLine("--------------------");

            var cmdeLux = new CommandeLuxembourg();
            cmdeLux.SetMontantHT(100);
            cmdeLux.CalculTTC();
            cmdeLux.Affiche();

            Console.Read();
        }
    }
}
