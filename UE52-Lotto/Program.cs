/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 07.02.2025
 *------------------------------------------------------
    Description:
        A lotto program
 *------------------------------------------------------
*/  

using System;

namespace lotto
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int[] userPick = new int[6];
            Console.WriteLine("Please enter your lottery pick (6 unique numbers between 1 and 45).");
            for (int i = 0; i < 6; i++)
            {
                bool valid = false;
                while (!valid)
                {
                    Console.Write("Number {0}: ", i + 1);
                    string input = Console.ReadLine();
                    int num;
                    if (int.TryParse(input, out num))
                    {
                        if (num < 1 || num > 45)
                        {
                            Console.WriteLine("The number must be between 1 and 45. Please try again.");
                        }
                        else
                        {
                            bool duplicate = false;
                            for (int j = 0; j < i; j++)
                            {
                                if (userPick[j] == num)
                                {
                                    duplicate = true;
                                    break;
                                }
                            }
                            if (duplicate)
                            {
                                Console.WriteLine("This number has already been entered. Please choose a different number.");
                            }
                            else
                            {
                                userPick[i] = num;
                                valid = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a number.");
                    }
                }
            }
            Console.Write("Your lottery pick is: ");
            foreach (int number in userPick)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
            int simulationCount = 0;
            bool validSimulationCount = false;
            while (!validSimulationCount)
            {
                Console.Write("How many draws would you like to simulate? ");
                string simInput = Console.ReadLine();
                if (int.TryParse(simInput, out simulationCount))
                {
                    if (simulationCount <= 0)
                    {
                        Console.WriteLine("The number of draws must be greater than 0.");
                    }
                    else
                    {
                        validSimulationCount = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                }
            }
            int[] matchCounts = new int[7];
            for (int i = 0; i < simulationCount; i++)
            {
                int[] draw = new int[6];
                for (int j = 0; j < 6; j++)
                {
                    int num;
                    bool duplicate;
                    do
                    {
                        num = rnd.Next(1, 46);
                        duplicate = false;
                        for (int k = 0; k < j; k++)
                        {
                            if (draw[k] == num)
                            {
                                duplicate = true;
                                break;
                            }
                        }
                    } while (duplicate);
                    draw[j] = num;
                }
                int match = 0;
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if (userPick[j] == draw[k])
                        {
                            match++;
                            break;
                        }
                    }
                }
                matchCounts[match]++;
            }
            Console.WriteLine("\nSimulation results:");
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine("{0} correct: {1} times", i, matchCounts[i]);
            }
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
