using System;
using System.Collections.Generic;
using System.Text;

namespace _22AMBootCamp
{
    class Operations
    {
        //Methods

        public static void Arithmetic()
        {
            //Use the debugger to see the values!
            int a = 9;
            int b = 6;
            int c;

            a++; // ++ INCREMENT OPERATOR
            b--; // -- DECREMENT OPERATOR

            c = a + b;
            c = a - b;
            c = a * b;
            c = a / b;

            c = a % b; //Modulo Operator (a/b) but will return the REMAINDER!!!
            // a = 10, b = 5, 10/5 = 2 R 0 Answer: 0
            c = 15 % 2; // 15/2 = 7.5 7R1 Answer: 1

            //Asignment
            a += b; // Takes current value of a (10) and adds to it b (5) ANS: 15
            a -= b; // ANSW: 10
            a *= b; // (a=10, b=5) ANSW: 50
            a /= b; // (a=50, b=5) ANSW: 10
            a /= 7; // a=10, b=7 ANSW: 1

            


        }

        public static void Comparison()
        {
            int a = 10;
            int b = 45;
            int c = 10;
            Console.WriteLine(a == b);
            Console.WriteLine(a != b); //Not equal

        }
        
        public static void Logic()
        {
            bool hasWeapon = true;
            bool hasMagic = false;

            //Four operator: NOT ! , AND && , OR || , XOR ^
            if (!hasMagic) Console.WriteLine("No magic");
            if (hasWeapon && hasMagic) Console.WriteLine("Has a weapon and wields magic... very dangerous!");
            //For && to return TRUE, BOTH must be true TT
            if (hasWeapon || hasMagic) Console.WriteLine("Can attack with weapon OR magic");
            // OR can be TRUE for this combination: FT, TF, TT

            //XOR True for these combinations: FT, TF
            if (hasWeapon ^ hasMagic) Console.WriteLine("Only one attack method.");


        }

        public static void Ternary()
        {
            int a, b, c;
            a = 16;
            b = 19;
            c = (a < b) ? a : b; //Ternary operator
            // c = (test) ? (a if the test is true) : (b if the test is false)
            Console.WriteLine(c);

            //Equivalent code:
            if (a != b)
            {
                c = 1;
            }else
            {
                c = b;
            }

            //An even/odd tester
            string Answer = (a % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("{0} is {1} ", a, Answer);


        }
    }
}
