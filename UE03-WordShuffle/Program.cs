/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas
 *------------------------------------------------------
    Description:
        A Program that outputs all 6 combinations of 3 words
 *------------------------------------------------------
*/

namespace wordShuffle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first word: ");
            String word1 = Console.ReadLine();

            Console.WriteLine("Enter the 2nd word");
            String word2 = Console.ReadLine();

            Console.WriteLine("Enter the 3rd word");
            String word3 = Console.ReadLine();


            Console.WriteLine($"{word1} {word2} {word3}");
            Console.WriteLine($"{word2} {word1} {word3}");
            Console.WriteLine($"{word3} {word2} {word1}");

            Console.WriteLine($"{word3} {word1} {word2}");
            Console.WriteLine($"{word2} {word3} {word2}");
            Console.WriteLine($"{word1} {word3} {word2}");
            

        }
    }
}