using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CounterStrike
    {
        private string _playerName;
        private const int _pointsValue = 50;

        // Properties
        public double Points
        {
            get { return Skill.CurrentPoints; }
        }

        public Level Skill { get; set; }

        // Constructor
        public CounterStrike(string playerName)
        {
            // New players are 'Beginner' by default
            Skill = new Beginner(this);
            _playerName = playerName;
            Console.WriteLine("{0} is the new player !", playerName);
            Console.WriteLine();
        }

        public void KillEnemies(int enemies)
        {
            var points = enemies * _pointsValue;
            Skill.WinPoints(points);
            Console.WriteLine("{0} killed {1} enemies => you win {2} points", _playerName, enemies, points);
            Console.WriteLine(" Skill: {0}", Skill.GetType().Name);
            Console.WriteLine();
        }

        public void HasBeenKilled()
        {
            Skill.LoosePoints(_pointsValue);
            Console.WriteLine("You have been killed: {0} points left", Points);
            Console.WriteLine(" Skill: {0}", Skill.GetType().Name);
            Console.WriteLine();
        }
    }
}