using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Employee
    {
        private string name;
        private int hierarchyLevel;

        public Employee(string name, int level)
        {
            this.name = name;
            this.hierarchyLevel = level;
        }

        public virtual string Display()
        {
            var result = string.Format("{0} ({1})", this.name, this.GetType().Name);
            return result.PadLeft(3 * this.hierarchyLevel + result.Length);
        }
    }
}
