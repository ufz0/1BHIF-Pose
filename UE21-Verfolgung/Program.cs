using System;
namespace verfolgung
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Geschwindigkeit von Gruppe 1 (v1 in km/h): ");
            double v1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Geschwindigkeit von Gruppe 2 (v2 in km/h): ");
            double v2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Verspätung der Gruppe 2 (in Minuten): ");
            double delayOfGroup2 = Convert.ToDouble(Console.ReadLine());


            double x = delayOfGroup2 / 60.0;


            if (v2 <= v1)
            {
                Console.WriteLine("Gruppe 2 kann Gruppe 1 nicht einholen weil v2 <= v1 ist");
            }
            else
            {
                double t = (v2 * x) / (v2 - v1);

                int hours = (int)t;
                int minutes = (int)((t - hours) * 60);

                Console.WriteLine($"Gruppe 2 holt Gruppe 1 nach {hours} Stunden und {minutes} Minuten ein.");
            }
        }
    }
}