using System;
using System.Collections.Generic;
using System.Text;

namespace _22AMBootCamp
{
    public static class StringWork
    {

        public static void StringFeatures()
        {
            Console.WriteLine("Please enter some text: ");
            string text = Console.ReadLine();
            if( String.IsNullOrEmpty( text ))
            {
                Console.WriteLine("!!! Error. No text entered!!!");
            }
            else
            {
                Console.WriteLine("You entered {0}", text);
                string query = text.StartsWith("C#") ? "does" : "does not";
                Console.WriteLine("Your text {0} start with C#", query);
                query = text.EndsWith("fun") ? "does" : "does not";
                Console.WriteLine("Your text {0} end with 'fun'", query);
                query = text.Contains(" is") ? "does" : "does not";
                Console.WriteLine("Your text {0} contain 'is'", query);

            }
        }

        public static void ManipulatingString()
        {
            Console.WriteLine("Please enter some text: ");
            string text = Console.ReadLine();
            Console.WriteLine("You entered '{0}'", text);
            Console.WriteLine("\tText length: {0}", text.Length);
            text = text.Trim();
            Console.WriteLine("\tTrimmed Text length: {0}", text.Length);
            string upper = text.ToUpper();
            string lower = text.ToLower();
            Console.WriteLine("\t{0}\n\t{1}", upper, lower);
            //Padding
            upper.PadLeft(20, '*');
            upper.PadRight(20, '*');
            Console.WriteLine("\nPadded Left:\t{0}", upper);
        }

        public static void JoinAndCompare()
        {
            //A few different ways to join strings...
            string[] a = new string[3] { "Alpha", "Beta", "Gamma" };
            string s = String.Concat(a[0], a[2]);
            Console.WriteLine(s);
            s = String.Join(" -- ", a[0], a[2], a[1]);
            Console.WriteLine(s);
            s = a[0] + a[1] + a[2];
            Console.WriteLine(s);

            //Comparing strings
            int num = String.Compare(a[1], a[1]);
            Console.WriteLine("String compare result is {0}", num);
            Console.WriteLine(a[0] == a[1]); //this works, but not < or >

        }

        public static void FindingSubStrings()
        {
            string phrase = "the quick brown fox jumps over the lazy dog ";
            string searchterm = "the";
            int position = phrase.IndexOf(searchterm,31);
            Console.WriteLine(position);
        }

        public static void FormattingStrings()
        {
            //Specifiers: G = General, F = Fixed Point, N number with commas, C = Currency,
            // P = percent, 0.000 = Zero Padding

            int number = 3500;
            Console.WriteLine(number.ToString("G"));
            Console.WriteLine(number.ToString("F"));
            Console.WriteLine(number.ToString("N"));
            Console.WriteLine(number.ToString("C"));
            Console.WriteLine(number.ToString("C"));
            Console.WriteLine(number.ToString("P"));
            Console.WriteLine("Zero Padding {0:0000000.0000}", number);

            //Splitting!!!!!!!!!!!
            string data = "The quick brown fox jumps over the lazy dog";
            string[] items = data.Split(' ');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }


        }

        public static void DateStrings()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.DayOfWeek);
            Console.WriteLine(now.ToShortDateString());
            DateTime future = now.AddYears(15);
            Console.WriteLine(future.DayOfWeek);

            DateTime birthday = new DateTime(2004, 9, 21);
            DateTime nextYearBirthday = birthday.AddYears(1);
            Console.WriteLine(nextYearBirthday.DayOfWeek);
        }

        public static void StringWorkHW()
        {
            //Q1

            
            string text;
            do
            {
                Console.WriteLine("What is your name? it must not exceed 10 characters");
                text = Console.ReadLine();
                if (text.Length < 10 == false)
                {
                    Console.WriteLine("\nThe name {0} was to long. Please enter another", text);
                }
            } while (text.Length < 10 == false);

            Console.WriteLine("You entered '{0}'", text);
            Console.WriteLine("\tText length: {0}", text.Length);
            text = text.Trim();
            Console.WriteLine("\tTrimmed Text length: {0}", text.Length);
            string upper = text.ToUpper();
            Console.WriteLine("\t{0}", upper);

            //Q2

            do
            {
                Console.WriteLine("What is your name? It must begin with 'Z'");
                text = Console.ReadLine();
                if (text.StartsWith('Z') == false)
                {
                    Console.WriteLine("Invalid input. It must begin with 'Z'");
                }
            } while (text.StartsWith('Z') == false);
            string lower = text.ToLower();
            Console.WriteLine("\t{0}", lower);

            //Q3

            Console.WriteLine("\nPlease enter a list of weapons below seperated by a comma");
            text = Console.ReadLine();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            System.Console.WriteLine($"Original text: '{text}'");

            string[] words = text.Split(delimiterChars);
            System.Console.WriteLine($"{words.Length} words in text:");

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }

            //Q4

            
            Console.WriteLine("\nWhat Year Were you born?");
            int A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nWhat month were born?");
            int B = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nWhat day were you born?");
            int C = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("You were born on a Tuesday in {0}/{1}/{2}", B, C, A);

            //Q5

            Console.WriteLine("\nEnter a random word");
            string a = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                string letter = a.Substring(i, 1);
                if(i%2 == 0)
                {
                    Console.Write(letter.ToUpper());
                } else
                {
                    Console.Write(letter.ToLower());
                }
                
            }
            
        }
    }
}
