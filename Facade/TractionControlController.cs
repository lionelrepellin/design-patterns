﻿using System;

namespace Facade
{
    public interface ITractionControlController
    {
        bool Enabled { get; set; }
        void Enable();
        void Disable();
    }

    public class TractionControlController : ITractionControlController
    {
        public bool Enabled { get; set; }

        public void Enable()
        {
            Enabled = true;
            Console.WriteLine("Traction control enabled");
        }

        public void Disable()
        {
            Enabled = false;
            Console.WriteLine("Traction control disabled");
        }
    }
}
