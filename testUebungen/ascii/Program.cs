/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 28.01.2025
 *------------------------------------------------------
    Description:
        A little ascii program
 *------------------------------------------------------
*/


using System;

namespace ascii
{
    class program
    {
        static void Main()
        {
            char num = '1';

            if(num >= '0' && num <= '9')
            {
                Console.WriteLine("The character is a number");
            }
            else
            {
                Console.WriteLine("The character is not a number");
            }

            if(num >= 'A' && num <= 'Z')
            {
                Console.WriteLine("The character is an uppercase letter");
            }
            else
            {
                Console.WriteLine("The character is not an uppercase letter");
            }

            if(num >= 'a' && num <= 'z')
            {
                Console.WriteLine("The character is a lowercase letter");
            }
            else
            {
                Console.WriteLine("The character is not a lowercase letter");
            }

        }
    }
}