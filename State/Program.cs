using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  
 */
namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start a new game
            CounterStrike counterStrike = new CounterStrike("BlackSheep");

            // Beginner
            counterStrike.KillEnemies(1);

            // Intermediate
            counterStrike.KillEnemies(2);

            // Beginner
            counterStrike.HasBeenKilled();
            counterStrike.HasBeenKilled();
            
            // Expert
            counterStrike.KillEnemies(3);
            counterStrike.KillEnemies(2);
            
            Console.ReadKey();
        }
    }    
}