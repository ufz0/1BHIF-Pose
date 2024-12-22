using System;

namespace vocabTrainer
{
    class Program
    {
        static void Main()
        {
            int tries = 1;

            string englishWord = "";
            string germanWord = "";

            string input = "";

            Console.WriteLine("Vocab trainer\n=================");

            Console.WriteLine("Teacher part");
            
            Console.Write("Enter the english word: ");
            englishWord = Console.ReadLine();            

            Console.Write("Enter the german translation: ");
            germanWord = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\nStudent part: ");
            Console.WriteLine($"Enter the german translation for {englishWord}:");

            while(input != germanWord && tries < 10)
            {
                Console.Write($"Try {tries}: ");
                input = Console.ReadLine().ToLower();

                if(input != germanWord)
                {
                    tries++;
                }
            }
            if(input != germanWord)
            {
                Console.WriteLine("That's wrong, sorry");
            }

            switch(tries)
            {
                case 1:
                Console.WriteLine("Awesome, you knew it first try!");
                break;
                
                case 2:
                case 3:
                Console.WriteLine($"Good, just {tries} tries");
                break;

                case 4:
                case 5:
                Console.WriteLine("Practice a little bit, that's gonna work!");
                break;

                case int n when n > 5 && n < 10:
                Console.WriteLine("Practice, practice, practice!");
                break;

                case 10:
                Console.WriteLine("Sorry, that's not good");
                break;
            }

        }
    }
}


