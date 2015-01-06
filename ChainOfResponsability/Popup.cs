using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class Popup
    {
        protected Popup successor;

        public void SetSuccessor(Popup successor)
        {
            this.successor = successor;
        }
        
        public abstract void ProcessRequest();
    }
}
