/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 14.01.2025
 *------------------------------------------------------
    Description:
        Filters a text based on an eliminator
 *------------------------------------------------------
*/

using System;

namespace deleteChars
{
    class Program
    {
        static void Main()
        {
            string input;
            string eliminator;
            
            Console.WriteLine("Please enter a text: ");
            input = Console.ReadLine() ?? string.Empty;
            
            Console.WriteLine("Please enter an eliminator text: ");
            eliminator = Console.ReadLine() ?? string.Empty;

            string result = "";


            foreach (char c in input)
            {
                
                if (!eliminator.Contains(c))
                {
                    result += c;
                }
            }

            Console.WriteLine("Filtered text: " + result);
        }
    }
}
