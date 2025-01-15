/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 14.01.2025
 *------------------------------------------------------
    Description:
        Filters a tet based on a eliminator
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
            int inputLen;

            Console.WriteLine("Please enter a text: ");
            input = Console.ReadLine() ?? string.Empty;
            inputLen = input.Length;
            
            Console.WriteLine("Please enter a eliminator text: ");
            eliminator = Console.ReadLine() ?? string.Empty;

            string sum = "";



            for(int i = 0; i < inputLen; i++)
            {
                for(int j = 0; j < eliminator.Length; j++)
                {
                    if(input[i] != eliminator[j])
                    {
                        sum += input[i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}