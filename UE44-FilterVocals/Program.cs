/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 14.01.2025
 *------------------------------------------------------
    Description:
        Filter vocals from a text 
 *------------------------------------------------------
*/


using System;

namespace filtervocals 
{
    class Program 
    {
        static void Main()
        {
            string input;
            string output = "";
            int inputLen;
            int count = 0;
            Console.WriteLine("Enter a text: ");
            input = Console.ReadLine() ?? string.Empty;
            inputLen = input.Length;
/* 
            foreach(char i in input)
            {
                char lowered = Char.ToLower(i);
                if(lowered == 'a' || lowered == 'e' || lowered == 'i' || lowered == 'o' || lowered == 'u')
                {
                    output += i;
                }
            }
 */
            for(int i = 0; i < inputLen; i++)
            {
                char lowered = Char.ToLower(input[i]);
                if(lowered == 'a' || lowered == 'e' || lowered == 'i' || lowered == 'o' || lowered == 'u')
                {
                    count++;
                    output += input[i];
                }
            }
            
            Console.WriteLine($"The text {input} contains {count} vocal(s): {output}");
        }
    }
}