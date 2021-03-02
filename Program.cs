using System;

namespace GuessingGame
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Guess the Secret number! (1-100)");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            int SecretNumber = 42;
            int NumberOfGuesses = 4;

            for (int i = 0; i < NumberOfGuesses; i++)
            {
                Console.Write("Guess a number: ");
                string response = Console.ReadLine();
                int value;
                if (int.TryParse(response, out value))
                {
                    if ( value == SecretNumber && i == 0 )
                    {
                        Console.WriteLine($"That's Correct!!! It took you {i+1} guess!");
                        break;
                    } 
                    else if ( value == SecretNumber )
                    {
                        Console.WriteLine($"That's Correct!!! It took you {i+1} guesses!");
                        break;
                    } 
                    else
                    {
                        Console.WriteLine($"Not the one. {i+1}/4");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("That's not a number!");
                    Console.WriteLine("");
                    i--;
                }
            }
        }
    }
}
