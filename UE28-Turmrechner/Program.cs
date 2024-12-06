using System;

namespace PyramidOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            int currentValue;
            int multiplier;

            do
            {       
                Console.WriteLine("Pyramid of Numbers");
                Console.WriteLine("===================");
                Console.Write("Please enter number or 0 to exit: ");
                input = Convert.ToInt32(Console.ReadLine());

                currentValue = input;
                multiplier = 2;     
                for (int i = 0; i < 9; i++)
                {
                    int result = currentValue * multiplier;
                    Console.WriteLine($"{currentValue} * {multiplier} = {result}");
                    currentValue = result;
                    multiplier++;
                }


                for (int divider = 9; divider >= 2; divider--)
                {
                    int result = currentValue / divider;
                    Console.WriteLine($"{currentValue} / {divider} = {result}");
                    currentValue = result;
                }

/*                 Console.WriteLine("Press any key to continue ...");
                Console.ReadKey(); */
                Console.WriteLine("\n");
            }while(input != 0);
        }
    }
}
