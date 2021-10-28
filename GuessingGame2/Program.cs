using System;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            string hiddenWord = "Hippopotamus";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outofGuess = false;


            while(guess != hiddenWord && !outofGuess)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;

                }
                else
                {
                    outofGuess = true;
                }
                
            }
            if (outofGuess)
            {
                Console.Write("You Lose!");
            }
            else
            {
                Console.Write("You Win!");

            }


            Console.ReadLine();

        }
    }
}
