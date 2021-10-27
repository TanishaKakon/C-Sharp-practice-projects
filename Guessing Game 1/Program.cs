using System;

namespace Guessing_Game_1

{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); 

            GetUser();

            static void GetAppInfo()
            {
                string appName = "Number Guesser";
                string appVersion = "1.0";
                string appAuthor = "Tanisha";

                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                Console.ResetColor();


            }

            static void GetUser()
            {
                Console.WriteLine("What is your name?");

                string Name = Console.ReadLine();

                Console.WriteLine("Hello {0}, Let's play a game", Name);


            }

            while (true)
            {

                //int correctnumber = 19;
                Random random = new Random();

                int correctnumber = random.Next(1, 20);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 20");

                while (guess != correctnumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        ColorMessage(ConsoleColor.Red, "Please use an actual number");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctnumber)
                    {
                        ColorMessage(ConsoleColor.Red, "Wrong guess, try again");

                    }
                }

                ColorMessage(ConsoleColor.Green, "Correct");

                //Play again
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;

                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
                

             }

        }

        static void ColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }


    }
}
