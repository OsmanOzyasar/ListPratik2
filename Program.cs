using System;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = new List<string>();

            Console.WriteLine("Sizden 5 adet kahve ismi istiyoruz. Lütfen ekrana yazınız.");

            for (int i = 1; i < 6; i++)
            {
                Console.Write($"{i}. Kahve: ");
                string userInput = Console.ReadLine();
                coffees.Add(userInput);
            }

            Console.WriteLine("Girilen kahve isimleri: ");

            foreach (string coffe in coffees)
            {
                Console.WriteLine(coffe);
            }
        }
    }
}