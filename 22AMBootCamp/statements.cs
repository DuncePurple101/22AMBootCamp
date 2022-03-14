using System;
using System.Collections.Generic;
using System.Text;

namespace _22AMBootCamp
{
    public static class statements
    {
        public static void BranchingIf()
        {
            int PlayerLevel = 12; //Try changing this later...

            if (PlayerLevel < 4) //Few things in c# without a ; at the end
            {
                Console.WriteLine("\t\nYour level is less than 4");
                Console.WriteLine("more stuff...");
            }
            else if (PlayerLevel >= 4 && PlayerLevel <= 10)
            {
                Console.WriteLine("\n\tYour level is between 4 and 10 (inclusive)");
            }
            else
            {
                Console.WriteLine("\nYour level is greater than 10.");
            }

            //One Line Test...
            int Damage = 10;
            if (Damage > 5) Console.WriteLine("\nYour damage is bigger than 5"); //Note: using curly braces is perfectly fine in IF statements, but you don't have to if its one line of code.

        }

        public static void Switching()
        {
            int d = 8; //Using mod 7 to wrap weeks
            string Level = "";

            switch (d % 7) //No ; after starting a switch (Using %7 to wrap weeks)
            {
                case 1: //In case d == 1
                    Level = "House";
                    break;
                case 2: //In case d == 2
                    Level = "Cave";
                    break;
                case 3: //In case d == 3
                    Level = "Town";
                    break;
                case 4: //In case d == 4
                    Level = "Ocean";
                    break;
                case 5: //In case d == 5
                    Level = "Temple";
                    break;
                default:
                    Level = "Boss Room!!!";
                    break;
            }
            Console.WriteLine("\nYour in level {0} which is a {1} ", d, Level);

        }

        public static void ForLoop()
        {
            //Used for counting (often with integers)
            // for (initializer; test-expression; updater)
            for (int i = 0; i <= 15; i++) //no ; here
            {
                Console.WriteLine("/nYou have earned {0} EXP", i);
                
            }
            Console.WriteLine("!!LEVEL UP!!");

            //Nested For Loops
            //outer loop (i)
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("Outer Loop {0}", i);
                //inner loop (j)
                for (int j = 0; j<5; j++)
                {
                    Console.WriteLine("\tInner Loop {0}", j);
                }

            }
        }

        public static void WhileLoops()
        {
            //While (test-expression == true) { statements }
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("The value of i is {0}", i);
                i++;
            }

            //do-while loop TESTING gets done at the END (or bottom) of the loop
            int j = 0;
            do
            {
                Console.WriteLine("The value of j is {0}", j);
                j++;

            } while (j < 5);

            //do-whiles are used for accepting input from a user until they "q"
            do
            {
                Console.Write("Enter command: > ");
            } while (Console.ReadLine() != "q");

            
        }
        public static void LoopingArrays()
        {
            string[] monster = new string[4];
            monster[0] = "Fred the Foe";
            monster[1] = "Phil the Toe";
            monster[2] = "Frog the Tofu";
            monster[3] = "Joe the No";

            Console.WriteLine("Monster List:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("\t{0}", monster[i]);
            }

        }

        public static void ForEachIterations()
        {
            List<string> MagicTypes = new List<string>();
            MagicTypes.Add("Fire");
            MagicTypes.Add("Water");
            MagicTypes.Add("Life");
            MagicTypes.Add("Dark");
            MagicTypes.Add("Ice");
            MagicTypes.Add("Earth");
            MagicTypes.Add("Light");
            MagicTypes.Add("Lightning");

            Console.WriteLine("List of Magic you can choose");

            //Iterate through them...
            foreach( string M in MagicTypes)
            {
                Console.WriteLine("\t{0}", M);
            }
        }

    }
}
