using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public abstract class SingletonAbstract
    {
        protected List<string> Names;

        public SingletonAbstract()
        {
            Names = new List<string>();
            Console.WriteLine("--> Initialisation de la liste");
        }

        public void Add(string name)
        {
            Names.Add(name);            
        }

        public List<string> GetAll()
        {
            return Names;
        }
    }
}
