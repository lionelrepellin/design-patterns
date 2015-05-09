using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            // create popups with initialized state
            // each status can change the behaviour
            Popup exit = new Exit(true);
            Popup upload = new Upload(true);
            Popup auth = new Authentication(true);
            Popup quality = new Quality(true);

            // sets the sequence
            // Save before Exit ? >> Upload in progress ? >> User authenticated ? >> Quality control ok ? >> Go back to "My Account"
            exit.SetSuccessor(upload);
            upload.SetSuccessor(auth);
            auth.SetSuccessor(quality);

            // the user wants to exit the program
            exit.ProcessRequest();

            Console.Read();
        }
    }
}