using System;
using System.Threading;

namespace ChainOfResponsability
{
    public class Upload : Popup
    {
        private readonly bool _uploadInProgress;

        public Upload(bool uploadInProgress)
        {
            _uploadInProgress = uploadInProgress;
        }

        public override void ProcessRequest()
        {
            Console.WriteLine("Upload in progress ? {0}", _uploadInProgress);

            if (!_uploadInProgress && Successor != null)
            {
                Successor.ProcessRequest();
            }
            else if (Successor != null)
            {
                Console.Write(">> Please wait during file transfer");
                for (var i = 0; i < 20; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(200);
                }
                Console.WriteLine();
                Successor.ProcessRequest();
            }
        }
    }
}