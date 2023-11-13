// See https://aka.ms/new-console-template for more information

namespace C__basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Basic Console WriteLine & ReadLine -
            // Console.WriteLine("     /|");
            // Console.WriteLine("    / |");
            // Console.WriteLine("   /  |");
            // Console.WriteLine("  /   |");
            // Console.WriteLine(" /____|");

            // Console.ReadLine();


            // - Variables -
            // string characterName = "Tom";
            // int characterAge;
            // characterAge = 25;

            // Console.WriteLine("There once was a man named " + characterName);
            // Console.WriteLine("He was " + characterAge + " years old");

            // characterName = "Mike";
            // Console.WriteLine("He really liked the name " + characterName);
            // Console.WriteLine("But didn't like being " + characterAge);


            // - Data Types - 
            // string can store any characters
            // string phrase = "Girrafe Academy";

            // char only store one character
            // char grade = 'A';

            // integer can store negative number in c#
            // int age = -30;

            // decimal is exact, like money
            // double is right in the middle
            // float is less precise 
            // double gpa = 3.0;

            // bool isMale = true;

            // Constant is value not stored in a variable
            // Console.WriteLine(false);


            // - Working with Strings -
            // string phrase = "Giraffe " + "Academy";
            // Console.WriteLine(phrase.Length);
            // Console.WriteLine(phrase.ToLower());
            // Console.WriteLine(phrase.ToUpper());
            // Console.WriteLine(phrase.Contains("Aca"));

            // Console.WriteLine(phrase[0]);
            // returns -1 if not exist
            // Console.WriteLine(phrase.IndexOf("Academy"));
            // Console.WriteLine(phrase.Substring(8, 3));


            // - Math Methods - 
            // Console.WriteLine(Math.Abs(-40));
            // Console.WriteLine(Math.Pow(3.8, 2));
            // Console.WriteLine(Math.Sqrt(36));
            // Console.WriteLine(Math.Max(4, 90));
            // Console.WriteLine(Math.Min(4, 90));
            // Console.WriteLine(Math.Round(4.3));


            // - Getting User Inputs - 
            // Console.Write("Enter your name: ");
            // string name = Console.ReadLine();

            // Console.Write("Enter your age: ");
            // string age = Console.ReadLine();
            // Console.WriteLine("Hello " + name + " you're " + age);


            // - Building a Calculator -
            // int num = Convert.ToInt32("45");
            // Console.Write("Enter a number: ");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // double num1 = Convert.ToDouble(Console.ReadLine());

            // Console.Write("Enter another number: ");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // double num2 = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine(num1 + num2);


            // - Matlib games in C# - 
            // string color, pluralNoun, celebrity;

            // Console.Write("Enter a color: ");
            // color = Console.ReadLine();

            // Console.Write("Enter a plural noun: ");
            // pluralNoun = Console.ReadLine();

            // Console.Write("Enter a celebrity: ");
            // celebrity = Console.ReadLine();

            // Console.WriteLine("Roses are " + color);
            // Console.WriteLine(pluralNoun + " are blue");
            // Console.WriteLine("I love " + celebrity);


            // - Arrays - 
            // int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            // luckyNumbers[1] = 900;

            // Console.WriteLine(luckyNumbers[1]);

            // string[] friends = new string[10];
            // friends[0] = "Jim";
            // friends[1] = "Kelly";

            // Console.WriteLine(friends[1]);

            // - Call Methods - 
            // SayHi("Hendy", 20);
            // SayHi("Mike", 22);
            // SayHi("John", 12);

            // - Methods with return -
            // int cubedNumber = cube(5);
            // Console.Write(cubedNumber);


            // - If else statement -
            /* bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.Write("You are tall male");
            } else if (isMale && !isTall)
            {
                Console.Write("You are a short male");
            } else if (!isMale && isTall) 
            {
                Console.Write("Your are not a male but you are tall");
            } else
            {
                Console.WriteLine("You are either not male or tall or both");
            } */

            // Console.WriteLine(GetMax(1, 10, 40));


            // - Building a better calculator -
            /*Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Oprator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else
            {
                Console.WriteLine("Invalid Operator!");
            }*/
        }

        // - Methods -
        /* static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        } */

        // - Return methods
        /* static int cube(int num)
        {
            int result = num * num * num;
            return result;

        }*/

        // - More in if else statement -
        /* static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3) 
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        } */


    }
}