using System;
using System.Collections.Generic;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            // TOPIC 1: VARIABLES & DATA TYPES

            #region Variables
            Console.WriteLine("\n--- TOPIC 1: VARIABLES ---");

            int wholeNumber = 10;           
            double decimalNumber = 5.99;    
            char singleCharacter = 'A';    
            string text = "Hello Code";    
            bool isCSharpFun = true;       

            var myName = "Developer";

            Console.WriteLine($"Int: {wholeNumber}, Double: {decimalNumber}, Bool: {isCSharpFun}");
            #endregion

            // TOPIC 2: TYPE CASTING
            #region Type Casting
            Console.WriteLine("\n--- TOPIC 2: TYPE CASTING ---");

            int myInt = 9;
            double myDouble = myInt;

            double myPi = 3.14;
            int myIntPi = (int)myPi;

            Console.WriteLine($"Original Double: {myPi}, Casted Int: {myIntPi}");

            string numberString = "123";
            int convertedNumber = Convert.ToInt32(numberString);
            #endregion

            // TOPIC 3: OPERATORS & MATH
            #region Operators
            Console.WriteLine("\n--- TOPIC 3: OPERATORS ---");

            int x = 10;
            int y = 3;

            Console.WriteLine($"Addition: {x + y}");
            Console.WriteLine($"Modulus (Remainder): {x % y}"); 
            x++;
            y--;

            
            bool isAdult = true;
            bool hasTicket = false;

         
            if (isAdult && !hasTicket)
            {
                Console.WriteLine("You are an adult but need a ticket.");
            }
            #endregion

            // TOPIC 4: STRINGS
            #region Strings
            Console.WriteLine("\n--- TOPIC 4: STRINGS ---");

            string firstName = "John";
            string lastName = "Doe";

            string fullNameOld = firstName + " " + lastName;

            string fullNameNew = $"{firstName} {lastName}";

            Console.WriteLine($"Full Name: {fullNameNew}");
            Console.WriteLine($"Length: {fullNameNew.Length}");
            Console.WriteLine($"Upper Case: {fullNameNew.ToUpper()}");
            #endregion

            // TOPIC 5: IF / ELSE
            #region If/Else
            Console.WriteLine("\n--- TOPIC 5: IF / ELSE ---");

            int time = 20;
            if (time < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }

            string result = (time < 18) ? "Daytime" : "Nighttime";
            Console.WriteLine(result);
            #endregion

            // TOPIC 6: SWITCH STATEMENTS
            #region Switch
            Console.WriteLine("\n--- TOPIC 6: SWITCH ---");

            int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Some other day");
                    break;
            }
            #endregion

            // TOPIC 7: LOOPS
            #region Loops
            Console.WriteLine("\n--- TOPIC 7: LOOPS ---");

            Console.Write("While Loop: ");
            int i = 0;
            while (i < 3)
            {
                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine();

            Console.Write("For Loop: ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            #endregion

            // TOPIC 8: ARRAYS
            #region Arrays
            Console.WriteLine("\n--- TOPIC 8: ARRAYS ---");

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            cars[0] = "Opel";

            foreach (string car in cars)
            {
                Console.Write(car + " ");
            }
            Console.WriteLine();
            #endregion
*/

            // TOPIC 9: LISTS (Dynamic Size)
            #region Lists
            Console.WriteLine("\n--- TOPIC 9: LISTS ---");

            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Remove("Apple");

            Console.WriteLine($"Fruit List Count: {fruits.Count}");
            #endregion

        }
    }
}