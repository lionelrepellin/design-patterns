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
            /*
            // On crée un chevalier
            Humain chevalier = new Homme();
            Console.WriteLine(chevalier.Description + ", poids : " + chevalier.Poids() + " kg ");

            // On crée une princesse
            Humain princesse = new Femme();
            Console.WriteLine(princesse.Description + ", poids : " + princesse.Poids() + " kg ");

            // Le chevalier va mettre son armure (Il va se " décorer »)
            chevalier = new Armure(chevalier);
            Console.WriteLine(chevalier.Description + ", poids : " + chevalier.Poids() + " kg ");

            // La princesse va mettre son chapeau (Elle va se " décorer »)
            princesse = new Chapeau(princesse);
            Console.WriteLine(princesse.Description + ", poids : " + princesse.Poids() + " kg ");

            // La princesse (Qui vient de mettre son chapeau) va maintenant mettre son armure !
            // C’est une princesse – Chevalier !
            princesse = new Armure(princesse);
            Console.WriteLine(princesse.Description + ", poids : " + princesse.Poids() + " kg ");
            */
            
            var book = new Book("John Coffee", "My Life", 1);
            var borrower = new Borrower
            {
                Name = "Bob",
                Age = 12
            };

            var borowable = new Borrowable(book);

            borowable.BorrowItem(borrower);
            borowable.Display();
            borowable.ReturnItem(borrower);
            borowable.Display();
 
            Console.Read();
        }
    }

    public abstract class Humain
    {
        public abstract string Description { get; }
        public abstract double Poids();
    }

    public class Homme : Humain
    {
        // On réécrit la méthode poids du parent
        public override double Poids()
        {
            // Poids moyen d'un homme
            return 75.0;
        }

        // On réécrit la méthode poids du parent
        public override string Description
        {
            // Description d'un homme
            get { return "Un homme"; }
        }
    }

    public class Femme : Humain
    {
        // On réécrit la méthode poids du parent
        public override double Poids()
        {
            // Poids moyen d'une femme
            return 60.0;
        }

        // On réécrit la méthode poids du parent
        public override string Description
        {
            // Description d'une femme
            get { return "Une femme"; }
        }
    }

    public abstract class DecorateurHumain : Humain
    {
        public override double Poids()
        {
            return -1;
        }

        public override string Description
        {
            get { return "Un décorateur Abstrait..."; }
        }
    }

    public class Armure : DecorateurHumain
    {
        private Humain humain;

        public Armure(Humain humain)
        {
            this.humain = humain;
        }

        public override double Poids()
        {
            return 12.0 + humain.Poids();
        }

        public override string Description
        {
            get { return humain.Description + " et son armure"; }
        }
    }

    public class Chapeau : DecorateurHumain
    {
        private Humain humain;

        public Chapeau(Humain humain)
        {
            this.humain = humain;
        }

        public override double Poids()
        {
            return 0.30 + humain.Poids();
        }

        public override string Description
        {
            get { return humain.Description + " et son chapeau"; }
        }
    }
}
