using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class CommandeHongrie : Commande
    {
        protected override void CalculTVA()
        {
            this.montantTVA = this.montantHT * 0.27;
        }
    }
}
