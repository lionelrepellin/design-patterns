using System;

namespace Builder
{    
    class Program
    {
        enum BurgerType
        {
            BigMac,
            CheeseBurger,
            Mine
        };

        static void Main(string[] args)
        {
            // change enum to see a different result
            var cook = CreateCook(BurgerType.BigMac);

            var waiter = new Waiter();
            waiter.ChooseCook(cook);

            // launch the manufacturing
            waiter.GiveTheOrderToStart();

            // the waiter give the burger to the customer
            var hamburger = waiter.GiveToTheCustomer();

            Console.WriteLine(hamburger);
            Console.Read();
        }

        static Cook CreateCook(BurgerType burgerType)
        {
            switch (burgerType)
            {
                case BurgerType.BigMac:
                    return new CookBigMac();
                case BurgerType.CheeseBurger:
                    return new CookCheeseBurger();
                case BurgerType.Mine:
                    return new MyBurger();
            }
            return null;
        }
    }


}