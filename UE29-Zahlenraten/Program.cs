using System;
using static System.Random;

namespace guessNumber
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(10);
            int input = -5;
            int count = 0; 

            Console.WriteLine("Welcome to number guessing");



            while(input != randomNumber )
            {   
                count++;
                Console.Write("Enter a number between 1 and 10: ");
                input = int.Parse(Console.ReadLine() ?? string.Empty);
                if(input != randomNumber)
                {
                    Console.WriteLine("Sorry, that's wrong\n");
                }
            }

            switch(count)
            {
                case int n when (n >= 1 && n <= 5):
                Console.WriteLine("Tolle Leistung! ");
                break;
                case int n when (n >= 6 && n <= 10):
                Console.WriteLine("Schon ganz gut!");
                break;
                case int n when (n > 10):
                Console.WriteLine("Endlich geschafft!");
                break;
            }
            
        }
    }
}