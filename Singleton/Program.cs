using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Optez pour le SingletonThreadSafe pour une utilisation dans un contexte multithreadé
    /// Avec plusieurs threads, l'initialisation du SingletonBasic est exécutée plusieurs fois.
    /// </summary>
    /// <see cref="http://jlambert.developpez.com/tutoriels/dotnet/implementation-pattern-singleton-csharp/"/>
    class Program
    {
        static SingletonBasic instance = null;
        //static SingletonThreadSafe instance = null;

        static void Main(string[] args)
        {
            var threads = new List<Thread>();
            var nbThreads = 20;

            // démarre tous les threads
            for (var i = 0; i < nbThreads; i++)
            {
                var t = new Thread(new ThreadStart(CreateSingleton));
                t.Start();
                threads.Add(t);
            }

            // attends tous les threads (retour au mode synchrone)
            foreach (var t in threads)
            {
                t.Join();
            }

            // récupère tous les noms qui ont été ajoutés et les affiche
            var list = instance.GetAll();
            foreach (var name in list)
            {
                Console.WriteLine(string.Format(">>> {0} est là !", name));
            }

            Console.Read();
        }

        /// <summary>
        /// Obtient l'instance du Singleton et insère des données
        /// </summary>
        static void CreateSingleton()
        {
            //instance = SingletonThreadSafe.Instance;
            instance = SingletonBasic.Instance;

            instance.Add(string.Format("{0} Bob l'Eponge", Thread.CurrentThread.ManagedThreadId));
            instance.Add(string.Format("{0} Patrick l'Etoile", Thread.CurrentThread.ManagedThreadId));
            instance.Add(string.Format("{0} Captain Crabs", Thread.CurrentThread.ManagedThreadId));
        }
    }
}
