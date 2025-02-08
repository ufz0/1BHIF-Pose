/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 08.02.2025
 *------------------------------------------------------
    Description:
        A program that counts the letters of a string
 *------------------------------------------------------
*/

using System;

class LetterCounter
{
    static void Main()
    {
        int[] counts = new int[26];

        Console.Write("Eingabetext: ");
        string input = Console.ReadLine();

        int length = input.Length;
        for (int i = 0; i < length; i++) 
        {
            char ch = input[i];

            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                int index = (ch >= 'a') ? ch - 'a' : ch - 'A';
                counts[index]++;
            }
        }

        Console.WriteLine("\nAnzahl der Buchstaben:\n");

        for (int i = 0; i < 26; i++)
        {
            Console.Write("{0}:{1:D3}  ", (char)('A' + i), counts[i]);

            if ((i+1) % 3 == 0)
                Console.WriteLine();
        }

        Console.WriteLine("\n\nDrücken Sie eine beliebige Taste . . .");
        Console.ReadKey();
    }
}
