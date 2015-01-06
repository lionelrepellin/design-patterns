using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Friend : IFriend
    {
        private string name;

        public Friend(string name)
        {
            this.name = name;
        }

        public void Update(User user)
        {
            Console.WriteLine("{0} a été notifié que le nouveau statut de {1} est '{2}'", this.name, user.Name, user.Status);
        }
    }
}
