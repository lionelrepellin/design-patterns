using System;

namespace ChainOfResponsability
{
    public class Exit : Popup
    {
        private readonly bool _wantToSave;

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
            else if (Successor != null)
            {
                Successor.ProcessRequest();
            }
        }
    }
}