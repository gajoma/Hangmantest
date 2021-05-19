using System;
using System.Linq;

namespace Hangmantest3
{
    class Program
    {
        static void Main(string[] args)
        {
            string guessWrd = "hello";
            int maxGuess = 10;
            char guessLtr;

            Console.WriteLine("Welcome to the Hangman Program!");
            Console.WriteLine();

            //run code in a while loop for number of guesses
            for (int i = 1; i <= maxGuess; i++)
            {

                //dump characters of string into an array
                char[] arrWrd = guessWrd.ToCharArray();

                //create counter for correct guesses
                //based on array length
                int goodCnt = arrWrd.Length;

                Console.Write("Please enter a letter: ");
                guessLtr = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

                //if character entered is in array...
                if (arrWrd.Contains(guessLtr))
                {
                    Console.WriteLine("{0}: Good Guess", guessLtr);
                    goodCnt--;
                    if (goodCnt == 0)
                    {
                        Environment.Exit(1);
                    }
                }
                else
                {
                    Console.WriteLine("{0}: Bad Guess", guessLtr);
                }
            }
        }
    }
}
