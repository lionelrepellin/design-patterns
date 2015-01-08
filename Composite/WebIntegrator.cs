using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class WebIntegrator : Employee
    {
        public WebIntegrator(string name, int level)
            : base(name, level)
        {
        }
    }
}
