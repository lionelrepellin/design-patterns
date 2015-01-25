using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Friend : IFriend
    {
        private string _name;

        public Friend(string name)
        {
            _name = name;
        }

        public void Update(User user)
        {
            Console.WriteLine("{0} a été notifié que le nouveau statut de {1} est '{2}'", _name, user.Name, user.Status);
        }
    }
}
