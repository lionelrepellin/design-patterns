using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Borrower
    {
        public int Age { get; private set; }
        public string Name { get; private set; }

        public Borrower(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Age);
        }
    }
}
