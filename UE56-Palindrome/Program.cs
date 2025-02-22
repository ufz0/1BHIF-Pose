/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 20.02.2025
 *------------------------------------------------------
    Description:
        A palindrom checker
 *------------------------------------------------------
*/

using System;


namespace palindromeChecker
{
    class Program
    {
        static void Main()
        {
            String input;
            do
            {
                Console.Write("Please enter a word (empty input = stop): ");
                input = Console.ReadLine();

                if(isPalindrome(input))
                {
                    Console.WriteLine($"{input} is a palindrome!");
                }else
                {
                    Console.WriteLine($"{input} is not a palindrome");
                }
                
            }while(input != "");

        }
        static bool isPalindrome(String input)
        {
            string reversed = "";
            
            for(int i = input.Length-1; i > -1;  i--)
            {
                char current = input[i];
                reversed += current;
            }
            return input == reversed;
        }
    }
}