using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MyBurger : Cook
    {
        public override void AddSteak()
        {
            this.Hamburger.Steak(3);
        }

        public override void AddCheese()
        {
            this.Hamburger.SliceOfCheese(2);
        }

        public override void AddSauce()
        {
            this.Hamburger.Sauce(true);
        }

        public override void AddSalad()
        {
            // it is not useful 
            this.Hamburger.Salad(false);
        }

        public override void AddGherkin()
        {
            // I hate this !
            this.Hamburger.Gherkin(false);
        }
    }
}
