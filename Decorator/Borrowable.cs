using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Borrowable : Decorator
    {
        protected List<Borrower> Borrowers;

        // Constructor
        public Borrowable(LibraryItem libraryItem)
            : base(libraryItem)
        {
            Borrowers = new List<Borrower>();
        }

        public void BorrowItem(Borrower borrower)
        {
            Borrowers.Add(borrower);
            this.LibraryItem.NumCopies--;
        }

        public void ReturnItem(Borrower borrower)
        {
            Borrowers.Remove(borrower);
            this.LibraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in Borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
