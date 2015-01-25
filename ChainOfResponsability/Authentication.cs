using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Authentication : Popup
    {
        private bool _loginOk;

        public Authentication(bool loginOk)
        {
            _loginOk = loginOk;
        }

        public override void ProcessRequest()
        {
            Console.WriteLine("User has been authenticated ? {0}", _loginOk);

            if (!_loginOk)
            {
                Console.WriteLine(">> Bad login or password !");                
            }
            else if (this.Successor != null)
            {
                Successor.ProcessRequest();
            }
        }
    }
}
