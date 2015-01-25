using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Exit : Popup
    {
        private bool _wantToSave;

        public Exit(bool wantToSave)
        {
            _wantToSave = wantToSave;
        }

        public override void ProcessRequest()
        {
            Console.WriteLine("Save before exit ? {0}", _wantToSave);

            if (!_wantToSave)
            {
                Console.WriteLine(">> Exit without saving");
            }
            else if (this.Successor != null)
            {
                Successor.ProcessRequest();
            }
        }
    }
}
