using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book("John Coffee", "My Life", 1);
            //var borrower = new Borrower("Bob", 12);
            
            //var borowable = new Borrowable(book);

            //borowable.BorrowItem(borrower);
            //borowable.Display();
            //borowable.ReturnItem(borrower);
            //borowable.Display();

            Glace maglace = new GlaceItalienne();
            maglace = new GoutChocolat(maglace);
            maglace = new GoutVanille(maglace);
            Console.WriteLine(maglace.Description);
            Console.ReadKey(); 

            Console.Read();
        }
    }

    public abstract class Glace
    {
        public virtual string Description
        {
            get
            {
                return "Glace virtuelle";
            }
        }
    }

    public class GlaceItalienne : Glace
    {
        public override string Description
        {
            get
            {
                return "glace italienne";
            }
        }
    }

    public class GlaceALeau : Glace
    {
        public override string Description
        {
            get
            {
                return "glace a l'eau";
            }
        }
    }

    public abstract class GlaceDecorator : Glace
    {
        protected Glace _glace;

        public override string Description
        {
            get
            {
                return _glace.Description;
            }
        }

    }

    public class GoutChocolat : GlaceDecorator
    {
        public GoutChocolat(Glace glace)
        {
            _glace = glace;
        }

        public override string Description
        {
            get
            {
                return _glace.Description + " avec du chocolat ";
            }
        }

    }

    public class GoutVanille : GlaceDecorator
    {

        public GoutVanille(Glace glace)
        {
            _glace = glace;
        }

        public override string Description
        {

            get
            {
                return _glace.Description + " avec de la vanille ";
            }
        }
    }
}
