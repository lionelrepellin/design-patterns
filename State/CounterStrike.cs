using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CounterStrike
    {
        private string playerName;
        private const int pointsValue = 50;

        // Properties
        public double Points
        {
            get { return this.Skill.CurrentPoints; }
        }

        public Level Skill { get; set; }

        // Constructor
        public CounterStrike(string playerName)
        {
            // New players are 'Beginner' by default
            this.Skill = new Beginner(this);
            this.playerName = playerName;
            Console.WriteLine("{0} is the new player !", playerName);
            Console.WriteLine();
        }

        public void KillEnemies(int enemies)
        {
            var points = enemies * pointsValue;
            this.Skill.WinPoints(points);
            Console.WriteLine("{0} killed {1} enemies => you win {2} points", playerName, enemies, points);
            Console.WriteLine(" Skill: {0}", Skill.GetType().Name);
            Console.WriteLine();
        }

        public void HasBeenKilled()
        {
            this.Skill.LoosePoints(pointsValue);
            Console.WriteLine("You have been killed: {0} points left", this.Points);
            Console.WriteLine(" Skill: {0}", this.Skill.GetType().Name);
            Console.WriteLine();
        }
    }
}