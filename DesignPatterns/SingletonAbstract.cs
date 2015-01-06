using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public abstract class SingletonAbstract
    {
        protected List<string> names;

        public SingletonAbstract()
        {
            names = new List<string>();
            Console.WriteLine("--> Initialisation de la liste");
        }

        public void Add(string name)
        {
            this.names.Add(name);            
        }

        public List<string> GetAll()
        {
            return this.names;
        }
    }
}
