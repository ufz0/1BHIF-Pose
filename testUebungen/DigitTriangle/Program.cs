/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 27.01.2025
 *------------------------------------------------------
    Description:
        A program to print a digit triangle.
 *------------------------------------------------------
*/
using System;


namespace digitTriangle
{
    class Program
    {
        static void Main()
        {
            int number = 6;

            for(int i = 1; i < number; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}