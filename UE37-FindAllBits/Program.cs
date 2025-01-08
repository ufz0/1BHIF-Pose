using System;

namespace FindallBits
{
    class Progam
    {
        static void Main()
        {
            string input; 
            string binary;
            uint value;
            Console.WriteLine($"Enter a number: (between 0 and {UInt32.MaxValue}) ");
            input = Console.ReadLine() ?? string.Empty;
            value = uint.Parse(input);
            binary = Convert.ToString(value, 2);
            Console.WriteLine("Dez: " + value);
            Console.WriteLine("Binary:"+binary);
        }
    }
}