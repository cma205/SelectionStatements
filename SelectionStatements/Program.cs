using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite genre of music?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "classic rock":
                    Console.WriteLine("You may think the term 'boomer' is a compliment.");
                    break;
                case "metal":
                    Console.WriteLine("Long hair don't care.");
                    break;
                case "country":
                    Console.WriteLine("Willie, Waylon, and Lil Nas X?");
                    break;
                case "electronic":
                    Console.WriteLine("I cAn HeAr ALL tHe CoLoRs");
                    break;
                case "hip hop":
                    Console.WriteLine("So, Tupac's in Cuba?");
                    break;
                case "pop":
                    Console.WriteLine("We all listen to Backstreet Boys sometimes.");
                    break;
                default:
                    Console.WriteLine($"{subject}? Never heard of it. Is that similar to crabcore?");
                    break;

            }
        }








           
    }
}
