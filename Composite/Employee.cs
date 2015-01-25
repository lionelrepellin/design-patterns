using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class Employee
    {
        private string _name;
        private int _hierarchyLevel;

        public Employee(string name, int level)
        {
            _name = name;
            _hierarchyLevel = level;
        }

        public virtual string Display()
        {
            var result = string.Format("{0} ({1})", _name, this.GetType().Name);
            return result.PadLeft(3 * _hierarchyLevel + result.Length);
        }
    }
}
