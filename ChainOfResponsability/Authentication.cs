using System;

namespace ChainOfResponsability
{
    class Authentication : Popup
    {
        private readonly bool _loginOk;

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
            else if (Successor != null)
            {
                Successor.ProcessRequest();
            }
        }
    }
}