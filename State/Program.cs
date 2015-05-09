using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start a new game
            CounterStrike counterStrike = new CounterStrike("BlackSheep");

            // BlackSheep kills enemies and wins points
            // his status change from Beginner to Intermediate
            counterStrike.KillEnemies(1);
            counterStrike.KillEnemies(2);

            // when BlackSheep dies
            // his status has gone back to Beginner
            counterStrike.HasBeenKilled();
            counterStrike.HasBeenKilled();
            
            counterStrike.KillEnemies(3);
            counterStrike.KillEnemies(2);
            
            Console.ReadKey();
        }
    }    
}