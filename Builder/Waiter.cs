using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Waiter
    {
        private Cook _cook;

        public void ChooseCook(Cook cook)
        {
            _cook = cook;
        }

        public Hamburger GiveToTheCustomer()
        {
            return _cook.GiveHamburger();
        }

        public void GiveTheOrderToStart()
        {
            _cook.CreateHamburger();
            _cook.AddSalad();
            _cook.AddSteak();
            _cook.AddCheese();
            _cook.AddSauce();
            _cook.AddGherkin();
        }
    }
}
