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

            Console.Write("Guess a number: ");
            string response = Console.ReadLine();
            Console.WriteLine($"You guessed {response}!");
        }
    }
}
