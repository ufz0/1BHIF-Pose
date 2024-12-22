using System;
using System.Threading;

class ChristmasTree
{
    static void Main()
    {
        const int height = 15;
        const int center = 20;
        const int trunkHeight = height / 5;
        const int trunkWidth = 3;

        while (true)
        {
            Console.Clear();
            DrawTree(height, center, trunkHeight, trunkWidth);
            Thread.Sleep(800);
        }
    }

    static void DrawTree(int height, int center, int trunkHeight, int trunkWidth)
    {
        Random random = new Random();
        for (int row = 0; row < height; row++)
        {
            int padding = center - row;
            int stars = 2 * row + 1;

            Console.Write(new string(' ', padding));

            for (int col = 0; col < stars; col++)
            {
                if (random.Next(10) < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write('@');
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write('*');
                }
            }

            Console.WriteLine();
        }

        int trunkPadding = center - trunkWidth / 2;
        for (int row = 0; row < trunkHeight; row++)
        {
            Console.Write(new string(' ', trunkPadding));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('|', trunkWidth));
        }

        Console.ResetColor();
    }
}
