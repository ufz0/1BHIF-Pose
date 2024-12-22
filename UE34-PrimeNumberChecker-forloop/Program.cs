using System;

namespace primeNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to check if it is a prime number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine(isPrime ? "Prime" : "Not Prime");
        }
    }
}