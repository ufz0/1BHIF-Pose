using System;

namespace stringRevers
{
    class Program
    {
        static void Main()
        {
            string input;   
            string reverse = "";

            Console.Write("Please enter a text that should be reversed: ");
            input = Console.ReadLine() ?? string.Empty;
            int len = input.Length;

            
            for(int i = len-1; i > -1; i--)
            {
                reverse += input[i];
            }
            Console.WriteLine(input+ " is "+reverse+ " in reverse");
        }
    }
}