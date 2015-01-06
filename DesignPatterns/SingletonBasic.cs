using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonBasic : SingletonAbstract
    {
        private static SingletonBasic singleton = null;

        private SingletonBasic()
            : base()
        {
            Console.WriteLine("--> Constructeur privé, doit être exécuté 1 seule fois");
        }

        public static SingletonBasic Instance
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new SingletonBasic();
                    Console.WriteLine("Création de l'instance");
                }
                return singleton;
            }
        }
    }
}
