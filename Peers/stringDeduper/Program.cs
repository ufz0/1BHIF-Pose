using System;

namespace stringDeduper
{
    class Program
    {
        static void Main()
        {
            string input;
            string sum = "";


            Console.WriteLine("Enter a string to remove duplicates from: ");
            input = Console.ReadLine().ToLower();



            foreach(char i in input)
            {
                if(!sum.Contains(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}