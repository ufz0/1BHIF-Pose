using System;

namespace fizzbuzz
{
    class Program 
    {
        static void Main()
        {
            int input; 

            Console.WriteLine("Enter a the maximum number: ");
            input = int.Parse(Console.ReadLine() ?? string.Empty);

            for(int i = 1; i<=input; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz-Buzz");
                }else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}