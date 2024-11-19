using System;
using System.Collections.Generic;

namespace statistics
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            int number = 1;     
            List<int> numberList = new List<int>();
            int sum = 0;
            int greatest = 0;
            int numberListCount = 0;
            int middleValue = 0;

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
                Console.WriteLine("Count: " + count);
                Console.WriteLine("Length: " + numberList.Count);
            }

            foreach(int i in numberList)
            {
                Console.WriteLine(i);
            }

            foreach(int i in numberList)
            {
                sum += i;
            }

            foreach(int i in numberList)
            {
                if(i > greatest)
                {
                    greatest = i;
                }
            }

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