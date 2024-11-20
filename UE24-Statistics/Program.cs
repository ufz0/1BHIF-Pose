using System;
using System.Collections.Generic;

namespace statistics
{
    class Program
    {
        static void Main()
        {
            var count = 0;
            var number = 1;     
            var numberList = new List<int>();
            var sum = 0;
            var numberListCount = 0;
            var middleValue = 0;

            Console.WriteLine("Some Statistics");
            Console.WriteLine("===============");

            while(number != 0)
            {
                Console.Write($"Please enter number {count +1}: (0=end) ");
                number = int.Parse(Console.ReadLine());
                if (number != 0)
                {
                    numberList.Add(number);
                    count++;
                }

            }

            sum = numberList.Sum();

            var greatest = numberList.Prepend(0).Max();

            numberListCount = numberList.Count;
            if (numberListCount > 0)
            {
                middleValue = sum / numberListCount;
            }

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Max: {greatest}");
            Console.WriteLine($"Avg: {middleValue}");
        }
    }
}