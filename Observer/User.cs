using System;
using System.Collections.Generic;

namespace Observer
{
    public class User
    {
        private string _status;
        private readonly List<IFriend> _friends = new List<IFriend>();

        public string Name { get; private set; }

        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                Notify();
            }
        }

        public User(string name, string status)
        {
            Name = name;
            _status = status;
        }

        public void Add(IFriend friend)
        {
            _friends.Add(friend);
        }

        public void Show()
        {
            Console.WriteLine("{0}'s status is '{1}'", Name, Status);
        }

        private void Notify()
        {
            foreach (var friend in _friends)
            {
                friend.Update(this);
            }

            Console.WriteLine();
        }
    }
}