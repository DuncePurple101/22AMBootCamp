using System;
using System.Collections.Generic;
using System.Text;

namespace _22AMBootCamp
{
    public static class MiniDC
    {
        public static void StartDC()
        {
            Console.WriteLine("Mini Dungeon Crawler... Welcome to Dark Souls 3");
            Console.WriteLine("What is your player's name?");
            string pName = Console.ReadLine();
            Player player = new Player(0, pName, 40);

            //start the player at a location
            int pX = 5;
            int pY = 5;

            //Created some monsters... an ARRAY
            Player[] monster = new Player[6];
            monster[0] = new Player(0, "", 0);
            monster[1] = new Player(1, "MegaGnome", 40);
            monster[2] = new Player(2, "RPG strapped to a Tiny Dragon", 50);
            monster[3] = new Player(3, "Elvis Presley", 100);
            monster[4] = new Player(4, "Willy the Weak", 5);
            monster[5] = new Player(5, "Cthulhu the God of the Deep", 1000000000);

            //Create some Locations
            int maxX = 11;
            int maxY = 11;
            Location[,] location = new Location[maxX, maxY];
            location[5, 5] = new Location("Home", "You are in a comfy chair near a crackling fire.", 0);
            location[1, 6] = new Location("Treasure Vault", "You discovered willy the weak who had been trapped in the vault for 5 years and is somehow still alive, but he discovers you and lunges at you", 4);
            location[4, 4] = new Location("Eldritch temple", "Black goop sticks to the walls and as you continue further you discover the ancient god Cthulhu", 5);
            location[7, 7] = new Location("Cave", "As you enter a cave you hear a ear piercing roar and as you ready your weapons readt to attack a tiny dragon appears wielding a RPG", 2);
            location[5, 9] = new Location("Hopsital", "You can heal yourself here", 0);
            location[9, 8] = new Location("Dojo", "welcome to the dojo", 0);

            //Create a random number generator
            Random dice = new Random();

            //Game begins
            while (true)
            {
                //Display the location & player health
                Console.WriteLine("\n------------------------------");
                Console.WriteLine("Your health: {0}", player.Health);
                Console.WriteLine("Your Location: ({0}, {1})", pX, pY);

                //details of location and monsters
                if (location[pX,pY] != null)
                {
                    Console.WriteLine(" *** {0} *** ", location[pX, pY].LocationName);
                    Console.WriteLine(" ^^^ {0} ^^^", location[pX, pY].Description);

                    //Monster Detection & Battle
                    if(location[pX,pY].MonsterID != 0)
                    {
                        int mID = location[pX, pY].MonsterID;
                        Console.WriteLine(" !!! You encounter {0} with health {1} !!!", monster[mID].Name, monster[mID].Health);

                        //Battle!
                        int damageToMonster = dice.Next(1, 12);
                        if (pX == 9 && pY == 8)
                        {
                            Console.WriteLine("You can train your attack here");
                            damageToMonster = dice.Next(2, 20);
                        }
                        int damageToPlayer = dice.Next(1, 12);

                        player.Health -= damageToPlayer;
                        monster[mID].Health -= damageToMonster;

                        //Show results
                        Console.WriteLine(" !!! You take {0} damage. !!!", damageToPlayer);
                        Console.WriteLine(" !!! {0} takes {1} damge. !!!", monster[mID].Name, damageToMonster);
                        Console.WriteLine(" !!! Your health: {0}. Monster's Health: {1}", player.Health, monster[mID].Health);

                        //Deal with death...
                        if(monster[mID].Health <= 0)
                        {
                            Console.WriteLine(" !! YOU KILL {0} !!!", monster[mID].Name);
                            location[pX, pY].MonsterID = 0; //Removes the mosnter from the room.
                            //location[pX, pY] = null; //Removes the location
                        }

                        if(player.Health <= 0)
                        {
                            Console.WriteLine("Your dead and thats all there is to it.");
                            return;
                        }

                    } //Monster ID is not 0


                } //location is not null

                if (pX == 5 && pY == 9)
                {
                    //Console.WriteLine("You start better...");
                    player.Health = 40; //Full health
                    //player.Health += 3; //Give +3 health
                    //player.Health += dice.Next(1, 6); //Roll a d6
                }


                //Ask user for commands...
                Console.Write("Please enter an order > ");
                string cmd = Console.ReadLine().ToLower().Trim();
                if ( cmd == "q" || cmd == "quit")
                {
                    Console.WriteLine("Your always welcomed back!");
                    return;
                }
                //Movement
                if (cmd == "n") pY--;
                if (cmd == "s") pY++;
                if (cmd == "e") pX++;
                if (cmd == "w") pX--;

                //Solve the off world problem...
                pX = Math.Clamp(pX, 0, maxX - 1);
                pY = Math.Clamp(pY, 0, maxY - 1);

                //TODO

                //Draw map
                if (cmd == "m") Location.DrawMap(location, pX, pY);
                try
                {
                    if (cmd == "save") DataManagement.SavePlayerData(player);
                }
                catch
                {
                    Console.WriteLine("Could not save player data");
                }

                if (cmd == "m") Location.DrawMap(location, pX, pY);
                try
                {
                    if (cmd == "load") player = DataManagement.LoadPlayerData(player);
                }
                catch
                {
                    Console.WriteLine("Could not load player data");
                }


            } //end of while(true)




        }
    }
}
