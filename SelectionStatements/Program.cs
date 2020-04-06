using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my number game!");
            Console.WriteLine("Try to guess my favorite number!");
            int favNumber = 7;
            var userInput = int.Parse(Console.ReadLine());
            if (favNumber < userInput)
            {
                Console.WriteLine("Sorry, that's too high.");
            }
            else if (favNumber > userInput)
            {
                Console.WriteLine("Sorry, that's too low.");
            }
            else
            {
                Console.WriteLine("That's it! Congratulations!");
            }









            
        }
    }
}
