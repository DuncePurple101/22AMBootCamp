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
            Player[] monster = new Player[5];
            monster[0] = new Player(1, "MegaGnome", 40);
            monster[1] = new Player(2, "RPG strapped to a Tiny Dragon", 50);
            monster[2] = new Player(3, "Elvis Presley", 100);
            monster[3] = new Player(4, "Willy the Weak", 5);
            monster[4] = new Player(5, "Cthulhu the God of the Deep", 1000000000);

            //Create some Locations
            int maxX = 11;
            int maxY = 11;
            Location[,] location = new Location[maxX, maxY];
            location[5, 5] = new Location("Home", "You are in a comfy chair near a crackling fire.", 0);
            location[4, 4] = new Location("Treasure Vault", "You discovered willy the weak who had been trapped in the vault for 5 years and is somehow still alive, but he discovers you and lunges at you", 4);
            location[1, 6] = new Location("Eldritch temple", "Black goop sticks to the walls and as you continue further you discover the ancient god Cthulhu", 5);
            location[1, 6] = new Location("Cave", "As you enter a cave you hear a ear piercing roar and as you ready your weapons readt to attack a tiny dragon appears wielding a RPG",5);

            //Create a random number generator
            Random dice = new Random();




        }
    }
}
