using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            // création des popups et initialisation de leur état
            Popup exit = new Exit(true);
            Popup upload = new Upload(true);
            Popup auth = new Authentication(true);
            Popup quality = new Quality(true);

            // mise en place de l'enchaînement 
            exit.SetSuccessor(upload);
            upload.SetSuccessor(auth);
            auth.SetSuccessor(quality);

            // traite les demandes en commençant
            // par la 1ère popup
            exit.ProcessRequest();

            Console.Read();
        }
    }
}
