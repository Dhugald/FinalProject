using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace AdventureGame
{
    class adventure
    {
        public struct Player
        {
            public int researchPoints;
            public bool inShip;
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
        public static void Venus(Planet[] planets)
        {

        }
        public static void Mercury(Planet[] planets)
        {


        }
        public static void Earth(Planet[] planets)
        {

        }

        public static void Mars(Planet[] planets, Player p, Ship s)
        {
            bool Searched = false;
            bool key = false;
            bool searchedHouse = false;
            bool houseSearched = false;
            while (p.inShip == false)
            {
                Console.WriteLine($"You arrive on Mars, you see a building in the distance\n");

                Console.WriteLine($"What do you do?\n");
                Console.WriteLine("Walk to".PadRight(7) + "- To walk to the building\n");
                Console.WriteLine("Enter".PadRight(7) + "- To enter ship\n");
                Console.WriteLine("Look".PadRight(7) + "- To look around\n");
                string input = Console.ReadLine().ToLower();
                if (input == "walk to")
                {
                    Console.WriteLine($"You walk to the building\n");
                    while (p.inShip == false)
                    {
                        Console.WriteLine($"What do you do?\n");
                        Console.WriteLine("Walk away".PadRight(7) + "- To walk back to the ship\n");
                        Console.WriteLine("Search".PadRight(7) + "- To search around the house\n");
                        Console.WriteLine("Open".PadRight(7) + "-To open the door\n");
                        string input2 = Console.ReadLine().ToLower();

                        if (input2 == "search")
                        {
                            Console.WriteLine("You search around the house and find a key.\n");
                            searchedHouse = true;
                            key = true;

                        }
                        else if (input2 == "search" && searchedHouse == true)
                        {
                            Console.WriteLine("You have already searched around and found they key.\n");
                        }

                        else if (input2 == "open" && key != true)
                        {
                            Console.WriteLine($"The door is locked.\n");
                        }
                        else if (input2 == "open" && key == true)
                        {
                            Console.WriteLine($"You use the key to open the door.\n");
                            houseSearched = false;
                            while (houseSearched == false)
                            {

                                Console.WriteLine($"What do you do?\n");
                                Console.WriteLine("Walk away".PadRight(7) + "- To walk back to the ship\n");
                                Console.WriteLine($"Enter".PadRight(7) + "- To enter the house\n");
                                string input3 = Console.ReadLine();

                                if (input3 == "enter")
                                {
                                    Console.WriteLine($"You enter the building and find yourself in an empty room\n");

                                    Console.WriteLine($"What do you do?\n");
                                    Console.WriteLine($"Search".PadRight(7) + "- To search the room\n");
                                    Console.WriteLine($"Exit".PadRight(7) + "- To exit the building\n");
                                    string houseInput = Console.ReadLine().ToLower();

                                    if (houseInput == "search")
                                    {
                                        Console.WriteLine($"While searching around the house you find some rocket fuel!\n");
                                        s.fuel = s.fuel + 50;
                                        Console.WriteLine($"Fuel has incresed to {s.fuel}\n");
                                        Console.WriteLine($"Research points increased!\n");
                                        p.researchPoints = p.researchPoints + 10;
                                        Console.WriteLine($"You now have {p.researchPoints} research points.\n");
                                        houseSearched = true;
                                    }
                                    else if (houseInput == "exit")
                                    {
                                        Console.WriteLine("You exit the building.\n");

                                        houseSearched = false;
                                        
                                    }
                                }
                                else if (input3 == "walk away")
                                {
                                    Console.WriteLine($"You walk back to the ship\n");
                                    houseSearched = true;

                                }

                            }
                        }
                    }
                }
                else if (input == "look" && Searched != true)
                {
                    Console.WriteLine($"You have already looked around, you stay at the ship.\n");
                }
                else if (input == "look")
                {
                    Console.WriteLine($"While looking around the ship you find some ship fuel\n");
                    s.fuel = s.fuel + 50;
                    Console.WriteLine($"50 Fuel added, total {s.fuel}");
                    Console.WriteLine($"You return to the ship.\n");
                    Searched = true;

                }

                else if (input == "enter")
                {
                    p.inShip = true;
                    Console.WriteLine("You entered the ship");
                }
            }

        }

        public static void Jupiter(Planet[] planets, Ship s, Player p)
        {
            bool Searched = false;
            bool key = false;
            bool looked = false;
            bool inCaves = false;
            bool atCaves = false;
            while (!p.inShip)
            {
                Console.WriteLine($"You arrive on Jupiter, You don't see much.\n");

                Console.WriteLine($"What do you do?\n");
                if (looked == true)
                {
                    Console.WriteLine("Walk to".PadRight(7) + "- To walk to the rocks\n");
                }
                Console.WriteLine("Enter".PadRight(7) + "- To enter ship\n");
                Console.WriteLine("Look".PadRight(7) + "- To look around\n");
                string input = Console.ReadLine().ToLower();
                if (input == "walk to" && looked == true)
                {

                    Console.WriteLine($"You walk to the rocks\n");
                    Console.WriteLine($"The rocks appear to be a cave");
                    atCaves = true;
                    while (atCaves)
                    {
                        Console.WriteLine("Enter".PadRight(7) + "- To enter the cave\n");
                        Console.WriteLine("Exit".PadRight(7) + "- To go back to the ship \n");
                        input = Console.ReadLine().ToLower();
                        if (input == "Enter")
                        {
                            Console.WriteLine("You enter the cave \n");
                            Console.WriteLine("The caves is dark but you can still see \n");
                            inCaves = true;
                            while (inCaves)
                            {
                                Console.WriteLine("Search".PadRight(7) + "- To search the cave\n");
                                Console.WriteLine("Exit".PadRight(7) + "- To go back to the ship \n");
                                else if (input == "exit")
                                {
                                    inCaves = false;
                                    Console.WriteLine("You exit the ship \n");
                                }
                            }
                        }
                        else if (input == "exit")
                        {
                            atCaves = false;
                            Console.WriteLine("You go back to the ship \n");
                        }
                    }
                }
                else if (input == "look" && looked == false)
                {
                    looked = true;
                    Console.WriteLine($"While looking around the ship you find some ship fuel\n");
                    s.fuel += 50;
                    Console.WriteLine($"50 Fuel added, Total: {s.fuel}");
                    Console.WriteLine($"You return to the ship.\n");

                    Console.WriteLine("While searching you notice some rocks in the distance");
                }
                else if (input == "look" && looked == true)
                {
                    Console.WriteLine("You already looked around!");
                    Console.WriteLine("While looking around before you found fuel and some rocks in the distance");
                }
            }
        }
        public static void Saturn(Planet[] planets)
        {

        }
        public static void Uranus(Planet[] planets)
        {
            
        }

        public static void Neptune(Planet[] planets)
        {

        }


        public static void shipSetup(ref Ship s)
        {
            s.location = "earth";
            s.fuel = 100;
        }
        public static void playerSetup(ref Player p)
        {
            p.inShip = true;
        }
        public static void GameInitialization(ref Player p, ref Ship s,Planet[] planets)
        {
            shipSetup(ref s);
            playerSetup(ref p);
            planets[1].name = "Mercury";
            planets[1].fuelDistance = 100;
            planets[2].environmnet = "something";
            planets[2].name = "Venus";
            planets[2].fuelDistance = 150;
            planets[3].name = "Earth";
            planets[3].fuelDistance = 200;
            planets[4].environmnet = "something";
            planets[4].name = "Mars";
            planets[4].fuelDistance = 250;
            planets[5].environmnet = "something";
            planets[5].name = "Jupiter";
            planets[5].fuelDistance = 300;
            planets[6].environmnet = "something";
            planets[6].name = "Saturn";
            planets[6].fuelDistance = 350;
            planets[7].environmnet = "something";
            planets[7].name = "Uranus";
            planets[7].fuelDistance = 400;
            planets[8].environmnet = "something";
            planets[8].name = "Neptune";
            planets[8].fuelDistance = 450;

        }


        public static void StartUp()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
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
            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }

        /**
        public static void MainMenu(Ship s)
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
                    SetDifficulty(s);
                    break;

            }
        }

    **/
        public static void SetDifficulty(Ship s)
        {
            Console.WriteLine("Please select a difficulty: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1".PadRight(7) + "Easy");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("2".PadRight(7) + "Regular");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("3".PadRight(7) + "Hard");
            Console.ForegroundColor = ConsoleColor.White;

            string temp = Console.ReadLine();
            int Difficulty = Convert.ToInt32(temp);
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
                    s.health = 150;
                    s.fuel = 100;
                    break;
                case 2:
                    s.health = 100;
                    s.fuel = 100;
                    break;

                case 3:
                    s.health = 50;
                    s.fuel = 50;
                    break;
            }
            Console.Clear();

            Console.WriteLine($"The ships starting health is: {s.health}");
            Console.WriteLine($"The ships starting fuel is: {s.fuel}");
            Console.ReadLine();
        }
        public static void flyEvent(Ship s)
        {
            Random rand = new Random();
            switch(rand.Next(1,11))
            {
                case 1:
                    Console.WriteLine("Encounter space pirates");
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("Encounter space pirates");
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    Console.WriteLine("Encounter comets");
                    break;
                case 9:
                    Console.WriteLine("Encounter comets");
                    break;
                case 10:
                    break;
                default:
                    break;
            }
        }
        public static void fuel(ref Ship s, string destination, Planet[] planets, ref bool enoughFuel)
        {
            int fuelUsage, fuelDesination = 0, fuelCurrentLocation = 0;
            switch (destination)
            {
                case "mercury":
                    fuelDesination = planets[1].fuelDistance;
                    break;
                case "venus":
                    fuelDesination = planets[2].fuelDistance;
                    break;
                case "earth":
                    fuelDesination = planets[3].fuelDistance;
                    break;
                case "mars":
                    fuelDesination = planets[4].fuelDistance;
                    break;
                case "jupiter":
                    fuelDesination = planets[5].fuelDistance;
                    break;
                case "saturn":
                    fuelDesination = planets[6].fuelDistance;
                    break;
                case "uranus":
                    fuelDesination = planets[7].fuelDistance;
                    break;
                case "neptune":
                    fuelDesination = planets[8].fuelDistance;
                    break;
                default:
                    break;
            }
            switch (s.location)
            {
                case "mercury":
                    fuelCurrentLocation = planets[1].fuelDistance;
                    break;
                case "venus":
                    fuelCurrentLocation = planets[2].fuelDistance;
                    break;
                case "earth":
                    fuelCurrentLocation = planets[3].fuelDistance;
                    break;
                case "mars":
                    fuelCurrentLocation = planets[4].fuelDistance;
                    break;
                case "jupiter":
                    fuelCurrentLocation = planets[5].fuelDistance;
                    break;
                case "saturn":
                    fuelCurrentLocation = planets[6].fuelDistance;
                    break;
                case "uranus":
                    fuelCurrentLocation = planets[7].fuelDistance;
                    break;
                case "neptune":
                    fuelCurrentLocation = planets[8].fuelDistance;
                    break;
            }

            fuelUsage = fuelDesination - fuelCurrentLocation;
           
            
            if(fuelUsage < 0)
            {
             
                fuelUsage = fuelUsage * -1;              
            }
            if(s.fuel < fuelUsage)
            {
                enoughFuel = false;
                
            }
            if (s.fuel >= fuelUsage)
            {

                enoughFuel = true;
 
                s.fuel = s.fuel - fuelUsage;
              
            }
        }
        public static void travel(ref Ship s,Player p, string input, Planet[] planets)
        {
            bool enoughFuel = false;
            if (input != s.location)
            {
                if (p.inShip)
                {
                    fuel(ref s, input, planets, ref enoughFuel);
                    if (enoughFuel)
                    {
                        flyEvent(s);
                        switch (input)
                        {
                            case "mercury":
                                s.location = "mercury";
                                Console.WriteLine("You successfully arrived to mecury.\n");
                                break;
                            case "venus":
                                s.location = "venus";
                                Console.WriteLine("You successfully arrived to venus.\n");
                                break;
                            case "earth":
                                s.location = "earth";
                                Console.WriteLine("You successfully arrived to earth.\n"); 
                                break;
                            case "mars":
                                s.location = "mars";
                                Console.WriteLine("You successfully arrived to mars.\n");
                                Mars(planets, p, s);
                                break;
                            case "jupiter":
                                s.location = "jupiter";
                                Console.WriteLine("You successfully arrived to jupiter.\n");
                                break;
                            case "uranus":
                                s.location = "uranus";
                                Console.WriteLine("You successfully arrived to uranus.\n");
                                break;
                            case "neptune":
                                s.location = "neptune";
                                Console.WriteLine("You successfully arrived to neptune.\n");
                                break;
                            default:
                                Console.Write("Invaild planet");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You do not have enough fuel!\n");
                    }

                }
                else
                {
                    Console.WriteLine("You are not in a ship!\n");
                }
            
            }
            else
            {
                Console.WriteLine("You are already here!\n");
            }

        }
        public static void cmdList()
        {
            Console.WriteLine("Fly".PadRight(7) + "- To fly to a planet");
            Console.WriteLine("Exit".PadRight(7) + "- To exit ship");
            Console.WriteLine("Enter".PadRight(7) + "- To enter ship\n");
        }
        public static void questCaller(Planet[] planets, Ship s, Player p)
        {
            if (!p.inShip)
            {
                switch (s.location)
                {
                    case "mercury":
                        Mercury(planets);
                        break;
                    case "venus":
                        break;
                    case "earth":
                        break;
                    case "mars":
                        Mars(planets, p, s);
                        break;
                    case "jupiter":
                        break;
                    case "saturn":
                        break;
                    case "uranus":
                        break;
                    case "neptune":
                        break;
                    default:
                        break;
                }
            }
        
        }
        static void Main(string[] args)
        {
            string[] inventory = new string[7];
            Planet[] planets = new Planet[9];
            Ship s = new Ship();
            Player p = new Player();
            GameInitialization(ref p, ref s, planets);
            StartUp();
            SetDifficulty(s);
            while (true)
            {
                questCaller(planets, s, p);
                cmdList();
                
                string input = Console.ReadLine().ToLower();

                if (input == "fly")
                {
                    
                    Console.Write("Enter planet to fly to: ");
                    input = Console.ReadLine().ToLower();
                    travel(ref s,p, input, planets);

                }
                else if (input == "exit")
                {
                    p.inShip = false;
                    Console.WriteLine("You exited the ship");
                }
                else if (input == "enter")
                {
                    p.inShip = true;
                    Console.WriteLine("You exited the ship");
                }

                
            }
        }
    }
}
