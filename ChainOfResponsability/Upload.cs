using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Upload : Popup
    {
        private bool _uploadInProgress;

        public Upload(bool uploadInProgress)
        {
            _uploadInProgress = uploadInProgress;
        }

        public override void ProcessRequest()
        {
            Console.WriteLine("Upload in progress ? {0}", _uploadInProgress);

            if (!_uploadInProgress && this.Successor != null)
            {
                Successor.ProcessRequest();
            }
            else if (this.Successor != null)
            {
                Console.Write(">> Please wait during file transfer");
                for (var i = 0; i < 20; i++)
                {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(200);
                }
                Console.WriteLine();
                Successor.ProcessRequest();
            }
        }
    }
}
