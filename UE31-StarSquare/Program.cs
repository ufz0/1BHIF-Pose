namespace starsquare
{
    class Program
    {
        static void Main()
        {
            const int CONSOLE_WIDTH = 80; 
            const int CONSOLE_HEIGHT = 25; 

            Console.WriteLine("Welche Seitenlänge soll das Stern-Quadrat besitzen? ");
            if (int.TryParse(Console.ReadLine(), out int sideLength) && sideLength > 0)
            {
                if (sideLength > CONSOLE_WIDTH || sideLength > CONSOLE_HEIGHT)
                {
                    Console.WriteLine($"Die Seitenlänge ist zu groß! Maximal {Math.Min(CONSOLE_WIDTH, CONSOLE_HEIGHT)}.");
                }
                else
                {

                    Console.SetWindowSize(CONSOLE_WIDTH, CONSOLE_HEIGHT);
                    Console.Clear();

                    int startX = (CONSOLE_WIDTH - sideLength) / 2;
                    int startY = (CONSOLE_HEIGHT - sideLength) / 2;

                    for (int i = 0; i < sideLength; i++)
                    {
                        Console.SetCursorPosition(startX, startY + i);
                        Console.WriteLine(new string('*', sideLength));
                    }

                    Console.WriteLine("\nDrücke eine Taste, um zu beenden.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte gib eine positive Zahl ein.");
            }
        }
    }
}
