using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            do
            {
                Random randomNumber = new Random();
                int realNumber = randomNumber.Next(5);

                Console.Write("Guess a number between 0 and 4: ");
                int guess = Convert.ToInt32(Console.ReadLine());
                int guessAmount = 1;
                Console.WriteLine();

                while (guess != realNumber)
                {
                    guessAmount++;
                    Console.Write("You guessed it wrong, try something {0}: ", guess < realNumber ? "higher" : "lower");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();


                    Console.Write("You guessed it wrong. Please try again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine($"You guessed it right, it took you {guessAmount} attempts.\n");

                Console.Write("Do you want to play again? (y/n): ");
                string playOption = Console.ReadLine();
                Console.WriteLine();

                if (playOption.ToLower().Equals("n"))
                    keepPlaying = false;

            } while (keepPlaying);
            Console.WriteLine("Thank you for playing the game!");

        }
    }
}
