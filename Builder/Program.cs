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
            var waiter = new Waiter();
            
            var cookBigMac = new CookBigMac();
            var cookCheeseBurger = new CookCheeseBurger();

            waiter.ChooseCook(cookBigMac);
            //waiter.ChooseCook(cookCheeseBurger);
            waiter.GiveTheOrderToStart();

            var hamburger = waiter.GiveToTheCustomer();

            Console.WriteLine(hamburger);
            Console.Read();
        }
    }
}
