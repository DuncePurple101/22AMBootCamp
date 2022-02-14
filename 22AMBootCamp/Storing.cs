using System;
using System.Collections.Generic;
using System.Text;

namespace _22AMBootCamp
{
    public static class Storing //Cant make objects
    {

        //Enums
        enum ListOfLevels { Grass, Water, Volcano, Sky, Cave, Dungeon, FinalBoss};

        //Methods
        public static void DemoVariables()
        {
            int PlayerID = 1187; //Integer, positive or Negative
            int StartingGold = 50; //Positive Only
            long BigNumber = 111111111111111; //Lets you have big numbers
            float pi = 3.14f; //Decimal numbers, do have limits, double or demical(see web)
            string PlayerName = "Casey";
            char firstInitial = 'C'; //Exactly one character
            bool HasGold = true; //true or false
            string Archtype = "Mage";
            string Archtype1 = "Fighter";
            string Archtype2 = "Archer";

            firstInitial++;

            Console.WriteLine("Your name is {0 and your first initial is {1}}", PlayerName, firstInitial);
        }

        public static void Readinginput()
        {
            Console.Write("What is your name Player?");
            string PlayerName = Console.ReadLine();
            Console.WriteLine("What is your Class?");
            string Archtype = Console.ReadLine();
            Console.WriteLine("Hello {0}. Welcome to game!", PlayerName);
            Console.Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old.", age);
            int ageInMonths = age * 12;
            Console.WriteLine("You are {0} months old.", ageInMonths);
            Console.WriteLine("You will start with 50 gold and spawn in a forest.");
            Console.ReadLine();
            Console.WriteLine("You spawned in a forest with a wooden staff on your back and a goblin blocks your way");
            Console.ReadLine();
            Console.WriteLine("You attack with your staff casting a fireball at the goblin lighting it on fire with a single attack and it dies");
            Console.ReadLine();
            Console.WriteLine("Would you like to save and quit?");
            Console.ReadLine();

        }

        public static void UsingArrays()
        {
            string[] enemyName = new string[5];
            enemyName[0] = "Goat the Goater";
            enemyName[1] = "Victor the gnome";
            enemyName[2] = "Logan the lacerator";
            enemyName[3] = "Eric the Eradicator";
            enemyName[4] = "Gavin the Great";
            //enemyName[5] = "Evan the Evil";

            int[] health = new int[5] { 50, 20, 99, 2, 2000 };

            System.Random random = new System.Random();
            int num = random.Next(5);

            while (true) //Forever loop
            {
                Console.WriteLine(enemyName[2] + " swings the sword!");
                Console.WriteLine("They have " + health[num] + " health");
                health[num]--;
                Console.ReadKey();
            }

        }

        public static void ConstansAndEnums()
        {
            //Constants
            //const double PI = 3.14;
            //Console.WriteLine(PI);

            //PI = 3.14;

            //Enums "enumerators" //must be declared PRIOR to the methods
            var Levels = ListOfLevels.Cave;

            if(Levels == ListOfLevels.Grass ||Levels == ListOfLevels.FinalBoss)
            {
                Console.WriteLine("This Level is to easy");
            }
            else
            {
                Console.WriteLine("I'm really scared");
            }


        }
    }
}
