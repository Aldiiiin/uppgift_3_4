using System;

namespace uppgift_3_4;
class Program
{
    static void Main()
    {
        Console.Write("Ange längden på låten i minuter: ");
        int minuter = int.Parse(Console.ReadLine());

        Console.Write("Ange längden på låten i sekunder: ");
        int sekunder = int.Parse(Console.ReadLine());

        // Konvertera minuter och sekunder till totala sekunder
        int totalSekunder = minuter * 60 + sekunder;

        // Kontrollera om låten är inom det tillåtna intervallet
        if (totalSekunder >= 165 && totalSekunder <= 260)
        {
            Console.WriteLine("Låten får spelas på radiostationen.");
        }
        else
        {
            Console.WriteLine("Låten får inte spelas på radiostationen.");
        }
    }
}
