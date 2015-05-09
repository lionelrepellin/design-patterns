using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize the status
            var me = new User("Lionel", "Online");

            // add friends to notify
            me.Add(new Friend("Jimmy"));
            me.Add(new Friend("Bruno"));
            me.Add(new Friend("Vincent"));

            // show the current status
            me.Show();

            Console.WriteLine();

            // the status change will trigger the notification
            Console.WriteLine("New status is: 'Disconnected'");
            me.Status = "Disconnected";

            Console.Read();
        }
    }
}