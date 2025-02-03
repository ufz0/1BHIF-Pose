/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 30.01.2025
 *------------------------------------------------------
    Description:
        A simple program to extract lower case chars
 *------------------------------------------------------
*/

using System;

namespace lowerCaseExtractor
{
    class lowerCaseExtractor
    {
        static void Main()
        {
            string input = "HaLLO Welten!";
            int startIndex = 1;
            int length = 3;
            string output = "";

            for(int i = startIndex; i < input.Length; i++)
            {
                char current = input[i];

                if(current >= 'a' && current <= 'z' && output.Length < length)
                {
                    output += current;
                }
            }
            
            Console.WriteLine(output);
        }
    }
}
