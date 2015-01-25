﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class User
    {
        private string _status;
        private List<IFriend> _friends = new List<IFriend>();

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
            Console.WriteLine("Le statut de {0} est '{1}'", Name, Status);
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