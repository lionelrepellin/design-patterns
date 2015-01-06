using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class User
    {
        private string status;
        private List<IFriend> friends = new List<IFriend>();

        public string Name { get; private set; }

        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                Notify();
            }
        }

        public User(string name, string status)
        {
            this.Name = name;
            this.status = status;
        }

        public void Add(IFriend friend)
        {
            this.friends.Add(friend);
        }

        public void Show()
        {
            Console.WriteLine("Le statut de {0} est '{1}'", this.Name, this.Status);
        }

        private void Notify()
        {
            foreach (var friend in this.friends)
            {
                friend.Update(this);
            }

            Console.WriteLine();
        }
    }
}
