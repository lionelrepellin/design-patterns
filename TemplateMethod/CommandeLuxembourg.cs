﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class CommandeLuxembourg : Commande
    {
        protected override void CalculTVA()
        {
            this.MontantTVA = this.MontantHT * 0.17;
        }
    }
}