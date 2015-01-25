using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem LibraryItem;

        // Constructor
        public Decorator(LibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }

        public override void Display()
        {
            LibraryItem.Display();
        }
    }
}
