using System;
using System.Collections.Generic;
using System.Text;

namespace _22AMBootCamp
{
    public class Player
    {
        //Properties
        public int ID; // 0 is reserved for the actual player, all others are monsters
        public string Name;
        public int Health;

        public Player(int iD, string name, int health)
        {
            ID = iD;
            Name = name;
            Health = health;
        }
    }
}
