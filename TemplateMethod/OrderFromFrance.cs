using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class OrderFromFrance : Order
    {
        protected override void VatCalculation()
        {
            this.Vat = this.ExcludingTaxes * 0.2;
        }
    }
}
