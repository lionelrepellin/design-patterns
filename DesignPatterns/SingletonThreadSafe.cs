using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonThreadSafe : SingletonAbstract
    {
        private static SingletonThreadSafe instance = null;
        private static readonly object padlock = new object();

        private SingletonThreadSafe()
            : base()
        {
            Console.WriteLine("--> Constructeur privé, doit être exécuté 1 seule fois");
        }

        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafe();
                        Console.WriteLine("Création de l'instance");
                    }
                    return instance;
                }
            }
        }
    }
}
