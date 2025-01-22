/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 21.01.2025
 *------------------------------------------------------
    Description:
    A word search program / game 
 *------------------------------------------------------
*/

using System;
namespace guessWord
{
    class Program
    {
        static void Main()
        {
            string inputWord;
            string output = "";
            int inputWordLen;
            int mistakes = 0;
            string guess = "";
            string input = "";

            Console.Write("Please enter a word for another person to guess: ");
            inputWord = Console.ReadLine() ?? string.Empty;
            inputWord = inputWord.ToUpper(); 
            inputWordLen = inputWord.Length;

            Console.Clear();

            while (output != inputWord && input != "*")
            {
                output = "";

                
                for (int i = 0; i < inputWordLen; i++)
                {
                    bool charGuessed = false;
                    for (int j = 0; j < guess.Length; j++)
                    {
                        if (inputWord[i] == guess[j])
                        {
                            charGuessed = true;
                            break;
                        }
                    }

                    if (charGuessed)
                    {
                        output += inputWord[i];
                    }
                    else
                    {
                        output += "?";
                    }
                }

                if (output == inputWord)
                {
                    break;
                }

                Console.Write($"Word: {output}, Mistakes: {mistakes}, Enter a guess (* to give up): ");
                input = Console.ReadLine()?.ToUpper() ?? string.Empty;

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a valid character!");
                    continue;
                }

                if (input == "*")
                {
                    Console.WriteLine("You gave up!");
                    break;
                }

                
                guess += input[0]; 

                
                bool found = false;
                for (int i = 0; i < inputWordLen; i++)
                {
                    if (inputWord[i] == input[0])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found) 
                {
                    mistakes++;
                }
            }

            if (output == inputWord)
            {
                Console.WriteLine($"You guessed the word: {inputWord}!");
                Console.WriteLine($"You made {mistakes} mistakes.");
            }
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
