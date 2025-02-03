/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 01.02.2025
 *------------------------------------------------------
    Description:
        A program that extracts a specific string from another
 *------------------------------------------------------
*/

using System;
using System.Security.Cryptography.X509Certificates;

namespace subString
{
    class subString
    {
        static void Main()
        {
            string input="";
            int inputLen;

            int subStart;
            int subEnd;

            string output="";

            Console.WriteLine("Extract lower case characters\n=============================");
            Console.WriteLine("Text eingeben:");
            input = Console.ReadLine() ?? string.Empty;
            inputLen = input.Length;
            do 
            {
                Console.WriteLine("Please enter a substring start index: ");
                subStart = int.Parse(Console.ReadLine() ?? string.Empty);

                Console.WriteLine("Please enter a substring end index: ");
                subEnd = int.Parse(Console.ReadLine() ?? string.Empty);

                if(subStart < 0 || subEnd >= inputLen || subEnd < subStart)
                {
                    Console.WriteLine("Invalid numbers entered\n");
                }
            } while(subStart < 0 || subEnd > inputLen || subEnd < subStart);

            for(int i = subStart; i< subEnd; i++)
            {
                output += input[i];
            }
            Console.WriteLine(output);
        }
    }
}