using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonThreadSafe : SingletonAbstract
    {
        private static SingletonThreadSafe _instance = null;
        private static readonly object _padlock = new object();

        private SingletonThreadSafe()
            : base()
        {
            Console.WriteLine("--> Constructeur privé, doit être exécuté 1 seule fois");
        }

        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (_padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonThreadSafe();
                        Console.WriteLine("Création de l'instance");
                    }
                    return _instance;
                }
            }
        }
    }
}
