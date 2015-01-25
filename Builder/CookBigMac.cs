using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CookBigMac : Cook
    {
        public override void AddSteak()
        {
            this.Hamburger.Steak(2);
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
            this.Hamburger.Salad(true);
        }

        public override void AddGherkin()
        {
            this.Hamburger.Gherkin(true);
        }
    }
}
