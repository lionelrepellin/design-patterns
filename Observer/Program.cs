using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var me = new User("Lionel", "Online");

            me.Add(new Friend("Jimmy"));
            me.Add(new Friend("Bruno"));
            me.Add(new Friend("Vincent"));

            // affiche le statut actuel
            me.Show();

            Console.WriteLine();

            // le changement de statut va déclencher 
            // automatiquement la notification
            Console.WriteLine("Changement de statut: 'Disconnected'");
            me.Status = "Disconnected";

            Console.Read();
        }
    }
}