using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // excluding taxes amount
            const int ExcludingTaxesAmount = 100;

            var orderFromFrance = new OrderFromFrance();
            orderFromFrance.ExcludingTaxesAmount(ExcludingTaxesAmount);

            // calculates the ATI amount depending on the country
            orderFromFrance.AllTaxesIncludedCalculation();

            // display the result
            orderFromFrance.Display();

            Console.WriteLine("--------------------\r\n");

            var orderFromLux = new OrderFromLuxembourg();
            orderFromLux.ExcludingTaxesAmount(ExcludingTaxesAmount);
            orderFromLux.AllTaxesIncludedCalculation();
            orderFromLux.Display();

            Console.WriteLine("--------------------\r\n");

            var orderFromMalte = new OrderFromMalta();
            orderFromMalte.ExcludingTaxesAmount(ExcludingTaxesAmount);
            orderFromMalte.AllTaxesIncludedCalculation();
            orderFromMalte.Display();

            Console.WriteLine("--------------------\r\n");

            var orderFromHongrie = new OrderFromHungary();
            orderFromHongrie.ExcludingTaxesAmount(ExcludingTaxesAmount);
            orderFromHongrie.AllTaxesIncludedCalculation();
            orderFromHongrie.Display();

            Console.Read();
        }
    }
}