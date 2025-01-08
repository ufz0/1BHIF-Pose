using System;

namespace splitstring
{
    class Program
    {
        static void Main()
        {
            string input;
            int inputLen;
            char splitter;

            Console.WriteLine("Please enter a text: ");
            input = Console.ReadLine() ?? string.Empty;
            inputLen = input.Length;

            Console.WriteLine("Splitcharacter: ");
            splitter = char.Parse(Console.ReadLine() ?? string.Empty);


            Console.WriteLine("**Output Text**");
            for(int i = 0; i < inputLen; i++)
            {
                if(input[i] == splitter)
                {
                    Console.WriteLine(input[i]);
                }else
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}