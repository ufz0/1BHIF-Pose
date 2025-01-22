/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas, 21.01.2025
 *------------------------------------------------------
    Description:
        A program that finds the longest series of the 
        same characters in a String
 *------------------------------------------------------
*/


using System;

namespace SameLetterSeriesdot
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter a text: ");
            string input = Console.ReadLine() ?? string.Empty;

            int longestLength = 0;
            int currentLength = 1;
            int longestStartIndex = 0;
            int currentStartIndex = 0;
            char longestChar = '\0';

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    currentLength++;
                    if (currentLength > longestLength)
                    {
                        longestLength = currentLength;
                        longestStartIndex = currentStartIndex;
                        longestChar = input[i];
                    }
                }
                else
                {
                    currentLength = 1;
                    currentStartIndex = i;
                }
            }

            if (longestLength > 0)
            {
                Console.WriteLine($"Longest series: '{longestChar}', Length: {longestLength}, Position: {longestStartIndex}");
            }
            else
            {
                Console.WriteLine("No series of repeating letters found.");
            }
        }
    }
}
