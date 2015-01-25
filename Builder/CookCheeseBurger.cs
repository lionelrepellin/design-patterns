using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CookCheeseBurger : Cook
    {
        public override void AddSteak()
        {
            this.Hamburger.Steak(1);
        }

        public override void AddCheese()
        {
            this.Hamburger.SliceOfCheese(1);
        }

        public override void AddSauce()
        {
            this.Hamburger.Sauce(true);
        }

        public override void AddSalad()
        {
            this.Hamburger.Salad(false);
        }

        public override void AddGherkin()
        {
            this.Hamburger.Gherkin(true);
        }
    }
}
