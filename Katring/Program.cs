using System;

namespace Katring
{
    class Program
    {
        static void Main(string[] args)
        {
            showIntro();
            Console.WriteLine();
            Console.WriteLine("Wprowadź liczbę szklanek składnika.");
            int cupsNeeded = int.Parse(Console.ReadLine());
            cupsToOunces(cupsNeeded);
        }
        public static void showIntro()
        {
            Console.WriteLine("Program służy do zmiany szkalnek");
            Console.WriteLine("na uncję. Dla Twojej wiadomości");
            Console.WriteLine("  1 szklanka = 8 uncji.");
        }
        public static void cupsToOunces(int cups)
        {
            int ounces;
            ounces = cups * 8;

            Console.WriteLine($"Ta ilość odpowaida {ounces} uncjom");
        }
    }
}
