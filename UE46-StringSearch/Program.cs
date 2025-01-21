/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 14.01.2025
 *------------------------------------------------------
    Description:
        A system that searches for a string in another string.
 *------------------------------------------------------
*/


using System; 
namespace stringSearch
{
    class Program
    {
        static void Main()
        {        
            Console.WriteLine("Enter a text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter a string to search for: ");
            string searcher = Console.ReadLine();

            int inputLen = input.Length;

            for (int i = 0; i < inputLen; i++)
            {
                int j = 0;
                while (j < searcher.Length && i + j < inputLen && input[i + j] == searcher[j])
                {
                    j++;
                }

                if (j == searcher.Length)
                {
                    Console.WriteLine("Found at index: " + i);
                    break;
                }
            }

        }   
    }
}