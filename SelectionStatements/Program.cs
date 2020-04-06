using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite genre of music?");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Classic Rock":
                    Console.WriteLine("The term 'boomer' is a compliment.");
                    break;
                case "Metal":
                    Console.WriteLine("Long hair don't care.");
                    break;
                case "Country":
                    Console.WriteLine("Willie, Waylon, and Lil Nas X?");
                    break;
                case "Electronic":
                    Console.WriteLine("I cAn HeAr ALL tHe CoLoRs");
                    break;
                case "Hip Hop":
                    Console.WriteLine("So, Tupac's in Cuba?");
                    break;
                default:
                    Console.WriteLine("Crabcore? Never heard of it. Try something more conventional.");
                    break;

            }
        }








           
    }
}
