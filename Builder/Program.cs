using System;

namespace Builder
{    
    class Program
    {
        static void Main(string[] args)
        {
            var waiter = new Waiter();

            // change value to see a different result
            const byte test = 1; // 2, 3

            switch (test)
            {
                case 1:
                    var cookBigMac = new CookBigMac();
                    waiter.ChooseCook(cookBigMac);
                    break;

                case 2:
                    var cookCheeseBurger = new CookCheeseBurger();
                    waiter.ChooseCook(cookCheeseBurger);
                    break;
                case 3:
                    var myBurger = new MyBurger();
                    waiter.ChooseCook(myBurger);
                    break;
            }

            // launch the manufacturing
            waiter.GiveTheOrderToStart();

            // the waiter give the burger to the customer
            var hamburger = waiter.GiveToTheCustomer();

            Console.WriteLine(hamburger);
            Console.Read();
        }
    }
}