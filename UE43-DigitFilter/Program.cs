/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 14.01.2025
 *------------------------------------------------------
    Description:
        Filters digits out of an input text
 *------------------------------------------------------
*/

using System;

namespace digitFilter
{
    class Program
    {
        static void Main()
        {
            string input;
            string ouput = "";
            int inputLen;
            Console.WriteLine("Enter a text: ");
            input = Console.ReadLine() ?? string.Empty;
            inputLen = input.Length;

            for(int i = 0; i < inputLen; i++)
            {
                if(input[i] >= '0' && input[i] <= '9')
                {
                    ouput += input[i];
                }
            }
            
            Console.WriteLine(ouput);
        }
    }
}