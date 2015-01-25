using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class Popup
    {
        protected Popup Successor;

        public void SetSuccessor(Popup successor)
        {
            Successor = successor;
        }
        
        public abstract void ProcessRequest();
    }
}
