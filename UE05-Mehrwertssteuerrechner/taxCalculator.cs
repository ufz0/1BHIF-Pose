using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Gib den aktuellen Preis ein:");
        double currentPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Steuerrechner auf Grundnahrungsmittel");
        Console.WriteLine("=====================================\n");

        Console.WriteLine($"Aktueller Verkaufspreis: {currentPrice}\n");

        double currentTaxPercent = 0.10;
        double netPrice = currentPrice / (1 + currentTaxPercent);
        Console.WriteLine($"Nettopreis: {netPrice:F2}");

        double currentTax = currentPrice - netPrice;
        Console.WriteLine($"Derzeitige Mehrwertsteuer: {currentTax:F2}");

        double newTaxPercent = 0.05;
        double newTax = netPrice * newTaxPercent;
        double newPrice = netPrice + newTax;
        double savings = currentPrice - newPrice;

        Console.WriteLine("\nWerte bei 5% Steuer");
        Console.WriteLine("-------------------");
        Console.WriteLine($"Mehrwertsteuer: {newTax:F2}");
        Console.WriteLine($"Zukünftiger Verkaufspreis: {newPrice:F2}");
        Console.WriteLine($"Ersparnis: {savings:F2}");

        Console.WriteLine("\nZum Beenden Eingabetaste drücken ...");
        Console.ReadLine();
    }
}
