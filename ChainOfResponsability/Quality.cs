using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Quality : Popup
    {
        private bool _allIsGood;

        public Quality(bool allIsGood)
        {
            _allIsGood = allIsGood;
        }

        public override void ProcessRequest()
        {
            Console.WriteLine("All elements are okay ? {0}", _allIsGood);

            if (!_allIsGood)
            {
                Console.WriteLine(">> You can change your creation");                
            }
            else if (this.Successor != null)
            {
                Successor.ProcessRequest();
            }
            else
            {
                Console.WriteLine("Go to order page");
            }
        }
    }
}
