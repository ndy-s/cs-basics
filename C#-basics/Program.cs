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
            string phrase = "Girrafe Academy";

            // char only store one character
            char grade = 'A';

            // integer can store negative number in c#
            int age = -30;

            // decimal is exact, like money
            // double is right in the middle
            // float is less precise 
            double gpa = 3.0;

            bool isMale = true;

            // Constant is value not stored in a variable
            Console.WriteLine(false);
        }
    }
}