using System;

namespace Observer
{
    public class Friend : IFriend
    {
        private readonly string _name;

        public Friend(string name)
        {
            _name = name;
        }

        public void Update(User user)
        {
            Console.WriteLine("{0} has been notified - {1}'s status is now '{2}'", _name, user.Name, user.Status);
        }
    }
}