using System;
using System.Collections.Generic;

class Product
{
    public double NetPrice { get; set; }
    public int Quantity { get; set; }
    public bool IsGiftWrapped { get; set; }

    public Product(double netPrice, int quantity, bool isGiftWrapped)
    {
        NetPrice = netPrice;
        Quantity = quantity;
        IsGiftWrapped = isGiftWrapped;
    }

    public double GetTotalPrice()
    {
        double price = NetPrice;
        if (IsGiftWrapped)
        {
            price += 2.50;
        }
        return price * Quantity;
    }
}

class ShoppingCart
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalNetPrice()
    {
        double totalNet = 0;
        foreach (var product in products)
        {
            totalNet += product.GetTotalPrice();
        }
        return totalNet;
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        Console.WriteLine("Geben sie ein Produkt ein oder 'done' zum Beenden.");

        while (true)
        {
            Console.Write("Geben sie den Netto-Verkaufspreis des Produkts ein: ");
            string priceInput = Console.ReadLine();
            if (priceInput.ToLower() == "done")
                break;

            double netPrice;
            if (!double.TryParse(priceInput, out netPrice))
            {
                Console.WriteLine("Ungültiger Preis.");
                continue;
            }

            Console.Write("Geben sie die Anzahl des Produkts ein: ");
            int quantity;
            if (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            {
                Console.WriteLine("Ungültige Stückzahl.");
                continue;
            }

            Console.Write("Soll die Ware als Geschenk verpackt werden (ja/nein)? ");
            bool isGiftWrapped = Console.ReadLine().ToLower() == "ja";

            cart.AddProduct(new Product(netPrice, quantity, isGiftWrapped));
        }

        Console.WriteLine("\nWohin soll die Ware geliefert werden? Bitte auswählen:");
        Console.WriteLine("1 - Deutschland (de)");
        Console.WriteLine("2 - Österreich (at)");
        string country = Console.ReadLine().ToLower();

        double taxRate = 0;
        if (country == "de")
        {
            taxRate = 0.19; 
        }
        else if (country == "at")
        {
            taxRate = 0.20;
        }
        else
        {
            Console.WriteLine("Ungültiges Land.");
            return;
        }

        double totalNetPrice = cart.GetTotalNetPrice();
        double taxAmount = totalNetPrice * taxRate;
        double totalBrutto = totalNetPrice + taxAmount;

        double shippingCost = 0;
        if (totalBrutto < 29.00)
        {
            shippingCost = 5.90;
            totalBrutto += shippingCost;
        }


        Console.WriteLine("\nRechnung:");
        Console.WriteLine($"Gesamt Netto Preis: {totalNetPrice:C2}");
        Console.WriteLine($"Mehrwertsteuer ({taxRate * 100}%): {taxAmount:C2}");
        if (shippingCost > 0)
        {
            Console.WriteLine($"Versandkosten: {shippingCost:C2}");
        }
        Console.WriteLine($"Gesamt Brutto Preis: {totalBrutto:C2}");
    }
}
