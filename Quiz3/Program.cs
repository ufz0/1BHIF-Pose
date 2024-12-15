/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 15.12.2024
 *------------------------------------------------------
    Description:
        A program that reads nubmers from the console and finds the greatest digit and also calculates the sum of all digits.
 *------------------------------------------------------
*/

namespace testAufgabe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 9999;
            const int MIN = 1; 

            int num = 0;
            string input;
            int digitSum = 0;
            int max = 0;

            int allTimeMax = 0;


            do
            {
                Console.Write("Geben Sie eine Zahl zwischen 1 und 9999 ein (0 = Ende): ");
                input = Console.ReadLine();

                num = int.Parse(input);
                if(num >= MIN && num < MAX)
                {
                    if (num != 0)
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            int currentIterationNum = int.Parse(input[i].ToString());

                            digitSum += currentIterationNum;

                            if (currentIterationNum > max)
                            {
                                max = currentIterationNum;
                            }

                        }
                        Console.WriteLine($"Die quersumme von {num} ist {digitSum} und die größte Ziffer ist {max}");
                        if(num > allTimeMax)
                        {
                            allTimeMax = num;
                        }

                    }
                    digitSum = 0;
                    max = 0;
                }

            }while(num != 0);

            

            Console.WriteLine("All time maximum: " + allTimeMax);

            Console.WriteLine("Zum Beenden beliebige Taste drücken ...");
            Console.ReadKey();
        }
        }
}