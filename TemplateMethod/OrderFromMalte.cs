using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class OrderFromMalte : Order
    {
        protected override void VatCalculation()
        {
            this.TaxeAmount = this.DutyFree * 0.18;
        }
    }
}
