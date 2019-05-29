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

        public static void Earth()
        {

        }
        public static void Mercury()
        {


        }

        public static void Venus(Planet[] planets)
        {
            planets[10].environmnet = "something";
            planets[10].name = "Venus";

        }

        public static void Mars(Planet[] planets)
        {
            planets[9].environmnet = "something";
            planets[9].name = "Venus";
        }

        public static void Jupiter()
        {

        }

        public static void Saturn()
        {

        }
        public static void Uranus()
        {

        }

        public static void Neptune()
        {

        }

        public static void GameInitialization()
        {
        }

        public static void MainMenu()
        {
    
        }

        static void Main(string[] args)
        {
            string[] inventory = new string[7];
            Planet[] planets = new Planet[8];
            Console.WriteLine("hello");
            Console.WriteLine("test");
            Console.WriteLine("test2");

            int i = new int[10];
            i[0] = 20
        }
    }
}
