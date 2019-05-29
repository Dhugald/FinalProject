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
            Console.WriteLine("Please select a menu option");
            Console.WriteLine("1        Set Difficulty");
            Console.WriteLine("2        ");
            Console.WriteLine("3        ");
            Console.WriteLine("_______________________________");
            string temp = Console.ReadLine();
            int menuOption = Convert.ToInt32(temp);
            Console.Clear();
            switch (menuOption)
            {
                case 1:
                    SetDifficulty();
                    break;

            }
        }
        public static void SetDifficulty()
        {
                      Console.WriteLine("Please select a difficulty: ");
            Console.WriteLine("1        Easy");
            Console.WriteLine("2        Regular");
            Console.WriteLine("3        Hard");
            string temp = Console.ReadLine();
            int Difficulty = Convert.ToInt32(temp);
            Ship[] shipStats = new Ship[1];
            int count = 0;
            if (Difficulty > 3)
            {
                Console.WriteLine("Please enter a vaild option menu");
                temp = Console.ReadLine();
                Difficulty = Convert.ToInt32(temp);
            }

            switch (Difficulty)
            {
                case 1:
                    shipStats[count].health = 150;
                    shipStats[count].fuel = 150;
                    break;
                case 2:
                    shipStats[count].health = 100;
                    shipStats[count].fuel = 100;
                    break;

                case 3:
                    shipStats[0].health = 50;
                    shipStats[0].fuel = 50;
                    break;
            }
            Console.Clear();

            Console.WriteLine($"The ships starting health is: {shipStats[0].health}");
            Console.WriteLine($"The ships starting fuel is: {shipStats[0].fuel}");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string[] inventory = new string[7];
            Planet[] planets = new Planet[8];
            

            MainMenu();
        }
    }
}
