using System;

class RabattSystem
{
    const int JUGENDRABATT = 5;
    const int SENIORENRABATT = 10;
    const int ELEKTRONIK_PRODUKTRABATT = 5;
    const int KLEIDUNG_PRODUKTRABATT = 10;

    static void Main()
    {
        
        Console.Write("Produktkategorie (Elektronik, Kleidung, Lebensmittel, Buch): ");
        string produktkategorie = Console.ReadLine();
        
        Console.Write("Preis des Produkts: ");
        double originalPreis = double.Parse(Console.ReadLine());
        
        Console.Write("Sofortrabatt (%): ");
        int sofortrabatt = int.Parse(Console.ReadLine());
        
        Console.Write("Alter des Kunden: ");
        int alter = int.Parse(Console.ReadLine());

        
        double preis = originalPreis * (100 - sofortrabatt) / 100.0;
        double sofortRabattWert = originalPreis - preis;

        
        double altersRabattWert = 0;
        if (alter < 18 && preis > 50)
        {
            altersRabattWert = preis * JUGENDRABATT / 100.0;
            preis -= altersRabattWert;
        }
        else if (alter >= 65 && sofortrabatt >= 10)
        {
            altersRabattWert = preis * SENIORENRABATT / 100.0;
            preis -= altersRabattWert;
        }

        
        double produktRabattWert = 0;
        switch (produktkategorie.ToLower())
        {
            case "elektronik":
                if (preis > 500)
                {
                    produktRabattWert = preis * ELEKTRONIK_PRODUKTRABATT / 100.0;
                    preis -= produktRabattWert;
                }
                break;

            case "kleidung":
                if (preis < 100 && alter < 30)
                {
                    produktRabattWert = preis * KLEIDUNG_PRODUKTRABATT / 100.0;
                    preis -= produktRabattWert;
                }
                break;

            default:
                break;
        }

        
        Console.WriteLine("\nErgebnis:");
        Console.WriteLine($"Produktkategorie: {produktkategorie}");
        Console.WriteLine($"Preis ...........: {originalPreis:F2}");
        if (sofortrabatt > 0)
        {
            Console.WriteLine($"Sofortrabatt ....: {sofortrabatt}% (-{sofortRabattWert:F2})");
        }
        if (altersRabattWert > 0)
        {
            Console.WriteLine($"Altersrabatt ....: {(alter >= 65 ? $"{SENIORENRABATT}%" : $"{JUGENDRABATT}%")} (-{altersRabattWert:F2})");
        }
        if (produktRabattWert > 0)
        {
            Console.WriteLine($"Produktrabatt ...: {(produktkategorie.ToLower() == "elektronik" ? $"{ELEKTRONIK_PRODUKTRABATT}%" : $"{KLEIDUNG_PRODUKTRABATT}%")} (-{produktRabattWert:F2})");
        }
        Console.WriteLine($"Endpreis nach Rabatten: {preis:F2}€");
    }
}
