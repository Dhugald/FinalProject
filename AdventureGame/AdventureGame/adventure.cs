﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
            public string location;
        }
        public struct Planet
        {
            public string name;
            public string environmnet;
            public int fuelDistance;
            public bool task;
        }

        public static void Earth(Planet[] planets)
        {
            planets[3].name = "Earth";
            planets[3].fuelDistance = 60;
        }
        public static void Mercury(Planet[] planets)
        {
            planets[1].name = "Mercury";
            planets[1].fuelDistance = 60;

        }

        public static void Venus(Planet[] planets)
        {
            planets[2].environmnet = "something";
            planets[2].name = "Venus";
            planets[2].fuelDistance = 60;

        }

        public static void Mars(Planet[] planets)
        {
            planets[4].environmnet = "something";
            planets[4].name = "Mars";
            planets[4].fuelDistance = 60;
        }

        public static void Jupiter(Planet[] planets)
        {
            planets[5].environmnet = "something";
            planets[5].name = "Jupiter";
            planets[5].fuelDistance = 60;
        }

        public static void Saturn(Planet[] planets)
        {
            planets[6].environmnet = "something";
            planets[6].name = "Saturn";
            planets[6].fuelDistance = 60;
        }
        public static void Uranus(Planet[] planets)
        {
            planets[7].environmnet = "something";
            planets[7].name = "Uranus";
            planets[7].fuelDistance = 60;
        }

        public static void Neptune(Planet[] planets)
        {
            planets[8].environmnet = "something";
            planets[8].name = "Neptune";
            planets[8].fuelDistance = 60;
        }


        public static void shipSetup(Ship s)
        {
            s.location = "earth";
        }
        public static void GameInitialization(Player p, Ship s)
        {
            shipSetup(s);

        }


        public static void StartUp()
        {
            Console.Title = "ASCII Art";
            string title = @"
            
  ____  _                  _        _   _                       ___________
 |  _ \| | __ _ _ __   ___| |_     | | | | ___  _ __           /@@@      @@\       __               _______
 | |_) | |/ _` | '_ \ / _ \ __|    | |_| |/ _ \| '_ \         /         @@@ \         \            /       \
 |  __/| | (_| | | | |  __/ |_     |  _  | (_) | |_) |       |  @@@@     @@  |         \___\    ==|=========|==
 |_|   |_|\__,_|_| |_|\___|\__|    |_| |_|\___/| .__/         \   @@@       /              /       \_______/
                                               |_|             \__@@_____@@/

                    ";
            Console.WriteLine(title);



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
            Ship s = new Ship;
            Player p = new Player();
            GameInitialization(p,s);
            StartUp();
            MainMenu();
            
        }
    }
}
