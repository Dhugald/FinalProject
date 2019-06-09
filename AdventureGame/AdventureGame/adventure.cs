using System;
using System.Threading;

namespace AdventureGame
{
    class Adventure
    {

        public static double oxygenMins;
        public static double speed;
        public static double metresMin;
        public static string landscape;

        public struct Player
        {
            public int health;
            public int speed;
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
        /**
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
            bool buildingOption = false;
            while (p.inShip == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You arrive on Mars, you see a building in the distance\n");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"What do you do?\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Walk to".PadRight(7) + "- To walk to the building\n");
                Console.WriteLine("Enter".PadRight(7) + "- To enter ship the ships option menu\n");
                Console.WriteLine("Look".PadRight(7) + "- To look around\n");
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine().ToLower();
                Console.Clear();
                if (input == "walk to")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You walk to the building\n");
                    while (buildingOption == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"What do you do?\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Walk away".PadRight(7) + "- To walk back to the ship\n");
                        Console.WriteLine("Search".PadRight(7) + "- To search around the house\n");
                        Console.WriteLine("Open".PadRight(7) + "-To open the door\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        string input2 = Console.ReadLine().ToLower();
                        Console.Clear();
                        if (input2 == "search")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You search around the house and find a key.\n");
                            searchedHouse = true;
                            key = true;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                            Console.Clear();

                        }
                        else if (input2 == "search" && searchedHouse == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have already searched around and found they key.\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                            Console.Clear();
                        }

                        else if (input2 == "open" && key != true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The door is locked.\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (input2 == "open" && key == true)
                        {
                            Console.WriteLine($"You use the key to open the door.\n");

                            Console.WriteLine($"What do you do?\n");
                            Console.WriteLine("Walk away".PadRight(7) + "- To walk back to the ship\n");
                            Console.WriteLine($"Enter".PadRight(7) + "- To enter the house\n");
                            string input3 = Console.ReadLine();
                            Console.Clear();
                            if (input3 == "enter")
                            {
                                Console.WriteLine($"You enter the house and start searching around.\n");
                                Console.WriteLine($"While searching around the house you find some rocket fuel!\n");
                                s.fuel = s.fuel + 50;
                                Console.WriteLine($"Fuel has incresed to {s.fuel}\n");
                                Console.WriteLine($"Research points increased!\n");
                                p.researchPoints = p.researchPoints + 10;
                                Console.WriteLine($"You now have {p.researchPoints} research points.\n");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else if (input3 == "walk away")
                            {
                                Console.WriteLine($"You walk back to the ship\n");
                                buildingOption = true;
                                Console.ReadLine();
                                Console.Clear();
                            }

                        }
                        else if (input2 == "walk away")
                        {
                            Console.WriteLine($"You walk back to the ship\n");
                            buildingOption = true;
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                }
                else if (input == "look" && Searched == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You have already looked around, you stay at the ship.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (input == "look")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"While looking around the ship you find some ship fuel\n");
                    s.fuel = s.fuel + 50;
                    Console.WriteLine($"50 Fuel added, total {s.fuel}");
                    Console.WriteLine($"You return to the ship.\n");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Searched = true;
                    Console.Clear();

                }

                else if (input == "enter")
                {
                    p.inShip = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You entered the ship");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        
        }

        public static void Jupiter(Planet[] planets, Ship s, Player p)
        {
            bool caveSearched = false;
            bool hasKey = false;
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
                                input = Console.ReadLine().ToLower();
                                if (input == "search" )
                                {
                                    if(!caveSearched)
                                    {
                                        s.fuel += 10;
                                        Console.WriteLine($"10 Fuel added, Total: {s.fuel}");
                                        Console.WriteLine($"You return to the ship.\n");
                                        caveSearched = true;
                                        if(!hasKey)
                                        {
                                            Console.Write("You found a chest\n");
                                            Console.Write("It needs a key to open it\n");
                                        }
                                        else
                                        {
                                            Console.Write("You found a chest\n");
                                            Console.Write("You can open it with you\n");
                                        }
                                        
                                    }
                                    else
                                    {

                                    }
                                }
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
            **/


        public static void ShipSetup(ref Ship s)
        {
            s.location = "earth";
            s.fuel = 100;
        }
        public static void PlayerSetup(ref Player p)
        {
            p.inShip = true;
           
        }
        public static void GameInitialization(ref Player p, ref Ship s,Planet[] planets)
        {
            ShipSetup(ref s);
            PlayerSetup(ref p);
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
            Console.Title = "Planet Hop";
            string title = @"
            
  ____  _                  _        _   _                       ___________
 |  _ \| | __ _ _ __   ___| |_     | | | | ___  _ __           /@@@      @@\       __               _______
 | |_) | |/ _` | '_ \ / _ \ __|    | |_| |/ _ \| '_ \         /         @@@ \         \            /       \
 |  __/| | (_| | | | |  __/ |_     |  _  | (_) | |_) |       |  @@@@     @@  |         \___\    ==|=========|==
 |_|   |_|\__,_|_| |_|\___|\__|    |_| |_|\___/| .__/         \   @@@       /              /       \_______/
                                               |_|             \__@@_____@@/
                                                                                                    
                    ";
            String loading = "";
            for (int i = 0; i <15; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue+i;
                Console.WriteLine(title);
                loading += ". ";
                Console.WriteLine("Loading".PadLeft(60));
                Console.WriteLine();
                Console.WriteLine("".PadRight(42) + loading);
                Thread.Sleep(700);
            }
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
            //int count = 0;
            if (Difficulty > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a vaild option menu");
                Console.ForegroundColor = ConsoleColor.White;
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
        public static void FlyEvent(Ship s)
        {
            Random rand = new Random();
            switch(rand.Next(1,11))
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Encounter space pirates");
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Encounter space pirates");
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Encounter comets");
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Encounter comets");
                    break;
                case 10:
                    break;
                default:
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Fuel(ref Ship s, string destination, Planet[] planets, ref bool enoughFuel)
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
        public static void Travel(ref Ship s,Player p, string input, Planet[] planets)
        {
            bool enoughFuel = false;
            if (input != s.location)
            {
                if (p.inShip)
                {
                    Fuel(ref s, input, planets, ref enoughFuel);
                    if (enoughFuel)
                    {
                        
                           FlyEvent(s);
                        Console.ForegroundColor = ConsoleColor.Green;
                        switch (input)
                        {
                            case "mercury":
                                s.location = "mercury";
                                Console.WriteLine("You successfully arrived to mecury.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("The weather is currently " + Weather(s.location) +" on "+ (s.location));
                                break;
                            case "venus":
                                s.location = "venus";
                                Console.WriteLine("You successfully arrived to venus.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("The weather is currently " + Weather(s.location) + " on " + (s.location));
                                break;
                            case "earth":
                                s.location = "earth";
                                Console.WriteLine("You successfully arrived to earth.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("The weather is currently " + Weather(s.location) + " on " + (s.location));
                                break;
                            case "mars":
                                s.location = "mars";
                                Console.WriteLine("You successfully arrived to mars.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("The weather is currently " + Weather(s.location) + " on " + (s.location));
                                //Mars(planets, p, s);
                                break;
                            case "jupiter":
                                s.location = "jupiter";
                                Console.WriteLine("You successfully arrived to jupiter.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("The weather is currently " + Weather(s.location) + " on " + (s.location));
                                break;
                            case "uranus":
                                s.location = "uranus";
                                Console.WriteLine("You successfully arrived to uranus.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("The weather is currently " + Weather(s.location) + " on " + (s.location));
                                break;
                            case "neptune":
                                s.location = "neptune";
                                Console.WriteLine("You successfully arrived to neptune.\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("The weather is currently " + Weather(s.location) + " on " + (s.location));

                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("Invaild planet");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                              
                        }
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You do not have enough fuel!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You are not in a ship!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You are already here!\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        public static void CmdList()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Fly".PadRight(7) + "- To fly to a planet");
            Console.WriteLine("Exit".PadRight(7) + "- To exit ship");         
            Console.WriteLine("Enter".PadRight(7) + "- To enter ship\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void QuestCaller(Planet[] planets, Ship s, Player p)
        {
            if (!p.inShip)
            {
                switch (s.location)
                {
                    case "mercury":
                        //Mercury(planets);
                        break;
                    case "venus":
                        break;
                    case "earth":
                        break;
                    case "mars":
                        //Mars(planets, p, s);
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

        public static string Weather(String planetName)
        {
            
            Random rnd = new Random();
            int caseSwitch;
            string weather = "clear";
        
        if (planetName.ToLower() == "mercury")
            {
                caseSwitch = rnd.Next(1, 3);
                switch (caseSwitch)
                {
                    case 1:
                        weather = "clear";
                        break;
                    case 2:
                        weather = "windy";
                        break;
                    case 3:
                        weather = "tornado";
                        break;
                }                
            }

        if (planetName.ToLower() == "venus")
            {
                caseSwitch = rnd.Next(1, 3);
                switch (caseSwitch)
                {
                    case 1:
                        weather = "clear";
                        break;
                    case 2:
                        weather = "acid rain";
                        break;
                    case 3:
                        weather = "heatwave";
                        break;   
                }
            }
            if (planetName.ToLower() == "jupiter")
            {
                caseSwitch = rnd.Next(1, 5);

                switch (caseSwitch)
                {
                    case 1:
                        weather = "clear";
                        break;
                    case 2:
                        weather = "hurricane";
                        break;
                    case 3:
                        weather = "tornado";
                        break;
                    case 4:
                        weather = "windy";
                        break;
                    case 5:
                        weather = "rain";
                        break;
                }

            }

           if (planetName.ToLower() == "mars")
            {
                caseSwitch = rnd.Next(1, 2);

                switch (caseSwitch)
                {
                    case 1:
                        weather = "clear";
                        break;
                    case 2:
                        weather = "windy";
                        break;
                }
            }
            if (planetName.ToLower() == "earth")
            {
                caseSwitch = rnd.Next(1, 10);

                switch (caseSwitch)
                {
                    case 1:
                        weather = "clear";
                        break;
                    case 2:
                        weather = "raining";
                        break;
                    case 3:
                        weather = "thunderstorm";
                        break;
                    case 4:
                        weather = "sandstorm";
                        break;
                    case 5:
                        weather = "snowing";
                        break;
                    case 6:
                        weather = "snowstorm";
                        break;
                    case 7:
                        weather = "sunny";
                        break;
                    case 8:
                        weather = "heatwave";
                        break;
                    case 9:
                        weather = "windy";
                        break;
                    case 10:
                        weather = "tornado";
                        break;
                }
            }


            if (planetName.ToLower() == "saturn")
            {
                caseSwitch = rnd.Next(1, 4);

                switch (caseSwitch)
                {
                    case 1:
                        weather = "clear";
                        break;
                    case 2:
                        weather = "cloudy";
                        break;
                    case 3:
                        weather = "windy";
                        break;
                    case 4:
                        weather = "tornado";
                        break;

                }
            }

            if (planetName.ToLower() == "neptune")
            {
                caseSwitch = rnd.Next(1, 4);

                switch (caseSwitch)
                {
                    case 1:
                        weather = "clear";
                        break;
                    case 2:
                        weather = "cloudy";
                        break;
                    case 3:
                        weather = "windy";
                        break;
                    case 4:
                        weather = "tornado";
                        break;
                }
            }

            if (planetName.ToLower() == "uranus")
            {
                caseSwitch = rnd.Next(1, 6);

                switch (caseSwitch)
                {
                    case 1:
                        weather = "clear";
                        break;
                    case 2:
                        weather = "cloudy";
                        break;
                    case 3:
                        weather = "windy";
                        break;
                    case 4:
                        weather = "tornado";
                        break;
                    case 5:
                        weather = "snowy";
                        break;
                    case 6:
                        weather = "snowstorm";
                        break;
                }
            }
            return weather;
        }
        /**
        public static double Oxygen()
        {
            int health = p.health;
            //5kmph / speed rate eg 5/75%
            double speed = 5 * (p.speed / 100);
            double metresMin = (speed * 1000) / 60;
            //full health= 7hrs oxygen aka 420 mins
            double oxygenMins = health * 4.2;
            return oxygenMins;
        }**/
        public static void Landscape(Ship s, Player p)
        {
                        
                Console.WriteLine("You left the ship.\n");
                Console.WriteLine("Health: " + p.health + "   Mins of Oxygen: " + oxygenMins + " Planet: " + s.location + "    Weather: " + Weather(s.location));
                

                if (s.location.ToLower() != "earth")
                {
                    if (Weather(s.location) == "acid rain")
                    {
                        GameOver();
                    }
                    else if (Weather(s.location) == "clear" || Weather(s.location) == "sunny" || Weather(s.location) == "cloudy")
                    {
                        p.speed = p.health;
                    }
                    else if (Weather(s.location) == "windy" || Weather(s.location) == "heatwave" ||
                        Weather(s.location) == "rain" || Weather(s.location) == "snowing")
                    {
                        //speed reduced by 25%
                        p.speed = ((p.health / 4) * 3);

                    }
                    else if (Weather(s.location) == "tornado" || Weather(s.location) == "hurricane" || Weather(s.location) == "thunderstorm"
                        || Weather(s.location) == "sandstorm" || Weather(s.location) == "snowstorm")
                    {
                        //speed reduced by 50%
                        p.speed = (p.health / 2);
                    }
                }
                /** 100% health = 7hrs oxygen
                 * 100% speed= 5km/hr
                 * 75% speed=3.75km hr
                 * 50% speed=2.5km hr
                 * max 35km **/
                Random rnd = new Random();
                int landscapeDistance = rnd.Next(1, 1000);

                

                int landscapeSwitch;
                landscapeSwitch = rnd.Next(1, 8);

                switch (landscapeSwitch)
                {
                    case 1:
                        landscape = "building";
                        break;
                    case 2:
                        landscape = "forest";
                        break;
                    case 3:
                        landscape = "cave";
                        break;
                    case 4:
                        landscape = "mountain";
                        break;
                    case 5:
                        landscape = "body of water";
                        break;
                    case 6:
                        landscape = "ruin";
                        break;
                    case 7:
                        landscape = "crash site";
                        break;
                }

                Console.WriteLine("You see that " + landscapeDistance + " metres away is a " + landscape);
                Console.WriteLine("What do you do?");
                Console.WriteLine("Approach - Approach the " + landscape);
                Console.WriteLine("Return - Return to the ship");
                string input = Console.ReadLine().ToLower();
                if (input == "return")
                {
                    p.inShip = true;
                    Console.WriteLine("You returned to your ship.");
                    p.health = 100;
                    Console.WriteLine("Health returned to 100%");
                    CmdList();
                }
            if (input == "approach")
            {
                int health = p.health;
                //5kmph / speed rate eg 5/75%
                double speed = 5 * (p.speed / 100);
                double metresMin = (speed * 1000) / 60;
                //full health= 7hrs oxygen aka 420 mins

                oxygenMins = (oxygenMins - (landscapeDistance / metresMin));
                Console.WriteLine("You arrived at the " + landscape);
                Console.WriteLine("Health: " + p.health + "   Mins of Oxygen: " + oxygenMins +
                    " Planet: " + s.location + "    Weather: " + Weather(s.location));
                LocationItem(p);
            }
            
         }

        public static void ShipReturn(Player p)
        {
            Random rnd = new Random();
            
            double used = 420 - oxygenMins;
            string returnChoice;
            int chance = rnd.Next(1 - 100);
            if (used > oxygenMins)
            {
                
                oxygenMins = oxygenMins - used;
                Console.WriteLine("You made it outside your ship with " + oxygenMins + " mins left!");
                p.inShip = true;
                oxygenMins = 420;
            }
            else
            {
                
                Console.WriteLine("Not enough reccomended amount of oxygen left to return.");
                Console.WriteLine("What do you do?");
                Console.WriteLine("Return - Risk it, and return to ship\nLook - look for oxygen supply nearby");
                returnChoice = Console.ReadLine().ToLower();
                if (returnChoice == "return")
                {
                    switch (chance)
                    {
                        case 1 - 90:
                            
                            Console.WriteLine("You ran out of oxygen");
                            GameOver();
                            break;
                        case 91 - 100:
                            
                            Console.WriteLine("By some miricle, you made it back to the ship!");
                            p.inShip = true;
                            break;
                    }

                }
                if (returnChoice == "look")
                {
                    switch (chance)
                    {
                        case 1 - 90:
                            
                            Console.WriteLine("You ran out of oxygen");
                            GameOver();
                            break;
                        case 91 - 100:
                            
                            Console.WriteLine("By some miricle, you found enough oxygen to make it back to the ship!");
                            p.inShip = true;
                            break;
                    }
                }
            }
        }

        public static void Detail(string detailIn, Player p)
        {
            Random rand = new Random();
            string choice;

            int doorChance = rand.Next(1 - 10);
           
            if (detailIn=="a door")
            {
                Console.WriteLine("Open - Open the door\nForce - Force the door to open\nKnock - Knock on the door\n" +
                                    "Return - Return to the ship");
                choice = Console.ReadLine().ToLower();
                if (choice == "open")
                {
                    switch (doorChance)
                    {
                        case 1 - 7:
                            Console.WriteLine("The door is locked. you need a key.\n");
                            oxygenMins = oxygenMins - 10;
                            break;
                        case 8 - 9:
                            Console.WriteLine("The door is unlocked, so you enter.\n");
                            oxygenMins = oxygenMins - 30;
                            oxygenMins = oxygenMins + 210;
                            Console.WriteLine($"After searching the room  for a while you find an oxygen tank, oxygen now at {oxygenMins} minutes of oxygen.");
                            break;
                    }
                }
                if (choice == "force")
                {
                    switch (doorChance)
                    {
                        case 1 - 7:
                            Console.WriteLine("You fail to open the door, you lose 25 health in the process.\n");
                            p.health = p.health - 25;
                            Console.WriteLine($"Your health is now {p.health}\n");
                            break;
                        case 8 - 9:
                            Console.WriteLine("You manage to force the door open, you enter the room.\n");
                            p.health = p.health - 10;
                            Console.WriteLine($"You use 30 minutes of oxygen trying to force the door.\n");
                            oxygenMins = oxygenMins - 30;
                            oxygenMins = oxygenMins + 210;
                            Console.WriteLine($"You lose some health trying. Health is now {p.health}\n.");
                            Console.WriteLine($"You also find an oxygen tank in the room! Oxygen now at {oxygenMins} minutes of oxygen.");
                            break;
                    }
                }
                if (choice == "knock")
                {
                    switch (doorChance)
                    {
                        case 1 - 8:
                            Console.WriteLine($"There is no reply to the knock./n");
                            break;
                        case 9:

                            Console.WriteLine($"A strange creature replys to the knock and you hear the door open.\n");
                            Console.WriteLine($"By some stroke of luck the creature understands english and you have a long conversation.");
                            Console.WriteLine($"You tell the creature that you're using a lot of oxygen and you're trying to find more.");
                            Console.WriteLine($"The creature offers you an oxygen tank that he has lying around");
                            oxygenMins = oxygenMins - 30;
                            oxygenMins = oxygenMins + 210;
                            Console.WriteLine($"Your oxygen has been increased to {oxygenMins}");
                            break;
                    }
                }
                if (choice == "return")
                {
                    ShipReturn(p);
                }
            }
            if (detailIn == "a skeleton")
            {
                Console.WriteLine("Search - search the skeleton\nRespect - Pay respect and take a moment of silence\n" +
                    "Bury - Bury the skeleton\nAvoid - Walk away from the skeleton" +
                                    "Return - Return to the ship");
                choice = Console.ReadLine().ToLower();
                if (choice == "return")
                {
                    ShipReturn(p);
                }
                if (choice == "search")
                {
                    string findings = "";
                    int option = rand.Next(1,3);
                    switch (option)
                    {
                        case 1:
                            findings = "nothing.";
                            break;
                        case 2:
                            findings = "a book";
                            break;
                        case 3:
                            findings = "a bag";
                            break;
                    }
                    oxygenMins = oxygenMins - 5;
                    Console.WriteLine("You found " + findings + " on the skeleton");
                    if (findings == "a book"|| findings=="a bag")
                    {
                        Detail(findings, p);
                    }
                    
                if (choice == "respect")
                {
                        Console.WriteLine("You take a moment of silence and respect the fallen.");
                        oxygenMins = oxygenMins - 2;
                    }
                if (choice == "bury")
                {
                        Console.WriteLine("You decide to bury the skeleton so it can move on in the after life.");
                        string findings = "";
                        int chance = rnd.Next(100);
                        oxygenMins = oxygenMins - 2;
                        switch (chance)
                        {
                            case 1 - 80:
                                findings = "nothing";
                                break;
                            case 81 - 90:
                                findings=""

                        }

                    }
                if (choice == "avoid")
                {
                    
                }
            }
            if (detailIn == "a bag")
                {

                }
            if (detailIn == "an engraving")
            {

            }
            if (detailIn == "a book")
            {

            }
        }
        public static void LocationItem(Player p)
        {
            int detailSwitch=0;
            Random rnd = new Random();
            if (landscape=="building")
            {
                detailSwitch = rnd.Next(1, 5);
            }
            if (landscape == "cave")
            {
                detailSwitch = rnd.Next(2, 5);
            }
            if (landscape == "mountain")
            {
                detailSwitch = rnd.Next(2, 5);
            }
            if (landscape == "body of water")
            {
                detailSwitch = rnd.Next(2, 5);
            }
            if (landscape == "forrest")
            {
                detailSwitch = rnd.Next(2, 5);
            }
            if (landscape == "ruin")
            {
                detailSwitch = rnd.Next(1, 5);
            }
            if (landscape == "crash site")
            {
                detailSwitch = rnd.Next(1, 5);
            }
            
            string detail="";
            switch (detailSwitch)
            {
                case 1:
                    detail = "a door";
                    break;
                case 2:
                    detail = "a skeleton";
                    break;
                case 3:
                    detail = "a bag";
                    break;
                case 4:
                    detail = "an engraving";
                    break;
                case 5:
                    detail = "a book";
                    break;
            }
            Detail(detail, p);
        }
       

        public static void GameOver()
        {
            String gameOverLogo = @"
            
  ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  
 ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
 ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
  ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ 
      ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     
                                                     ░                   
";          Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(gameOverLogo);
            Console.WriteLine("You died.");
            Console.ForegroundColor = ConsoleColor.White;
            
        }

        /**
        static void building()
        {
            Console.WriteLine("You see a building in the distance.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("Approach - Approach the building\nReturn - return to ship");
            string input = Console.ReadLine().ToLower();
            if (input =="approach")
            {
                switch(approachBuilding){
                    case "sucessful":
                        break;
                    case "weather changes":
                        break;
                    case "alien attack":
                        gameOver();
                        break;

                }
            }
            else if (input =="return")
            {
                p.inShip = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You entered the ship");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Sorry I dont undeerstand that answer, try again.");
                building();
            }
        }
    **/

           
        static void Main(string[] args)
        {

            string[] inventory = new string[7];
            Planet[] planets = new Planet[9];
            Ship s = new Ship();
            Player p = new Player();
            String planetName = s.location;
            p.health = 100;
            p.speed = 100;

            int health = p.health;
            //5kmph / speed rate eg 5/75%
            Adventure.speed = 5 * (p.speed / 100);
            Adventure.metresMin = (speed * 1000) / 60;
            //full health= 7hrs oxygen aka 420 mins
            Adventure.oxygenMins = health * 4.2;
            

            Game(inventory, planets, s, p);
        }
        static void Game(string[] inventory, Planet[] planets, Ship s, Player p) { 
            GameInitialization(ref p, ref s, planets);
            StartUp();
            SetDifficulty(s);
            while (p.inShip==true)
            {
                
                QuestCaller(planets, s, p);
                CmdList();
                
                string input = Console.ReadLine().ToLower();

                if (input == "fly")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter planet to fly to: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    input = Console.ReadLine().ToLower();
                    Travel(ref s,p, input, planets);

                }
                else if (input == "exit")
                {
                    p.inShip = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You exited the ship");
                    Console.ForegroundColor = ConsoleColor.White;
                    Landscape(s,p);
                }
                else if (input == "enter")
                {
                    p.inShip = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You entered the ship");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                
            }
        }
    }
}
