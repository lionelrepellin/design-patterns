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
            // excluding taxes amount
            var excludingTaxesAmount = 100;

            var orderFromFrance = new OrderFromFrance();
            orderFromFrance.ExcludingTaxesAmount(excludingTaxesAmount);

            // calculates the ATI amount depending on the country
            orderFromFrance.AllTaxesIncludedCalculation();

            // display the result
            orderFromFrance.Display();

            Console.WriteLine("--------------------\r\n");

            var orderFromLux = new OrderFromLuxembourg();
            orderFromLux.ExcludingTaxesAmount(excludingTaxesAmount);
            orderFromLux.AllTaxesIncludedCalculation();
            orderFromLux.Display();

            Console.WriteLine("--------------------\r\n");

            var orderFromMalte = new OrderFromMalta();
            orderFromMalte.ExcludingTaxesAmount(excludingTaxesAmount);
            orderFromMalte.AllTaxesIncludedCalculation();
            orderFromMalte.Display();

            Console.WriteLine("--------------------\r\n");

            var orderFromHongrie = new OrderFromHungary();
            orderFromHongrie.ExcludingTaxesAmount(excludingTaxesAmount);
            orderFromHongrie.AllTaxesIncludedCalculation();
            orderFromHongrie.Display();

            Console.Read();
        }
    }
}
