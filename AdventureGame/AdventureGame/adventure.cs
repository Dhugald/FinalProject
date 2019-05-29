using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class adventure
    {
        public struct Player
        {
            public int researchPoints;         
        }
        public struct Ship
        {
            public int health;
            public int fuel;
        }
        public struct Planet
        {
            public string name;
            public string environmnet;
            public int fuelLevel;
            public bool task;
        }
        static void Main(string[] args)
        {
            string[] inventory = new string[7];
            
            Console.WriteLine("hello");
            Console.WriteLine("test");
            Console.WriteLine("test2");
        }
    }
}
