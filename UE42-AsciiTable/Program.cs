using System;


namespace asciitable
{
    class Program
    {
        static void Main()
        {
            for(int i = 32; i < 127; i++)
            {
                Console.WriteLine($"Character: {(char)i} Code: {i} (dez) {i:X4} (hex)");
            }

        }
    }
}