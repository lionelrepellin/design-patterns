﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class OrderFromHungary : Order
    {
        protected override void VatCalculation()
        {
            this.Vat = this.ExcludingTaxes * 0.27;
        }
    }
}