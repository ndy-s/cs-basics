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

            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

        }
    }
}