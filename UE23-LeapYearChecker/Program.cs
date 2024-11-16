using System;

namespace leapYearChecker
{
    class Program
    {
        static void Main()
        {
            bool isLeapYear = false;
            Console.Write("Enter a year to check if it is a leap year: ");
            int year = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("\n");

            if(year < 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            if (year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }
            Console.WriteLine(isLeapYear ? $"The year {year} is a leap year!" : $"The year {year} is not a leap year!");
        }
    }
}