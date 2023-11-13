// See https://aka.ms/new-console-template for more information

namespace C__basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Basic Console WriteLine & ReadLine -
            Console.WriteLine("     /|");
            Console.WriteLine("    / |");
            Console.WriteLine("   /  |");
            Console.WriteLine("  /   |");
            Console.WriteLine(" /____|");

            Console.ReadLine();


            // - Variables -
            string characterName = "Tom";
            int characterAge;
            characterAge = 25;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);


            // - Data Types - 
            string can store any characters
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


            // - Working with Strings -
            string phrase = "Giraffe " + "Academy";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("Aca"));

            Console.WriteLine(phrase[0]);
            // its returns -1 if not exist
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.Substring(8, 3));


            // - Math Methods - 
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3.8, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.3));


            // - Getting User Inputs - 
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you're " + age);


            // - Building a Calculator -
            int num = Convert.ToInt32("45");
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);


            // - Matlib games in C# - 
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);


            // - Arrays - 
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);

            string[] friends = new string[10];
            friends[0] = "Jim";
            friends[1] = "Kelly";

            Console.WriteLine(friends[1]);

            // - Call Methods - 
            SayHi("Hendy", 20);
            SayHi("Mike", 22);
            SayHi("John", 12);

            // - Methods with return -
            int cubedNumber = cube(5);
            Console.Write(cubedNumber);


            // - If else statement -
            bool isMale = true;
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
            }

            Console.WriteLine(GetMax(1, 10, 40));


            // - Building a better calculator -
            Console.Write("Enter a number: ");
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
            }

            // - Switch statement -
            Console.WriteLine(GetDay(9));


            // - While Loop -
            int index = 6;

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5); 


            // - Guessing game -
            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.Write("You Lose!");
            } else
            {
                Console.Write("You Win!");
            }


            // - For Loops -
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }


            // - Exponent Method -
            Console.WriteLine(GetPow(2, 4));


            // - 2D Array -
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {4, 5},
            };

            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[0, 0]);


            // - Error Handler -
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("^^^^^^^^^^^^^");
            }

            Console.ReadLine();


            // - Class and Object -
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700);

            Console.WriteLine(book2.title);
            
            // Constructor & object methods
            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors()); 
            Console.WriteLine(student2.HasHonors());

            // Setter & Getter
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);

            // Static attributes
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);

            Console.WriteLine(holiday.title);
            Console.WriteLine(kashmir.title);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(holiday.getSongCount());

            // Static class
            UsefulTools.SayHi("Mike");

            // Inheritance
            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();

            Console.ReadLine();

        }

        // - Methods -
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        // - Return methods
        static int cube(int num)
        {
            int result = num * num * num;
            return result;

        }

        // - More in if else statement -
        static int GetMax(int num1, int num2, int num3)
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
        }

        // - Switch statement -
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }

        // - Exponent Method -
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        }

    }
}