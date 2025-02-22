/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 10.02.2025
 *------------------------------------------------------
    Description:
        A program to extract a sub string from a parent string
 *------------------------------------------------------
*/  

using System;

namespace filteredSubString
{
    class Program
    {
        static void Main()
        {
            Console.Write("Geben Sie einen String ein (Enter beendet): ");
            string input = Console.ReadLine();

            while(!string.IsNullOrEmpty(input))
            {
                int start = 0;
                bool validStart = false;
                while(!validStart)
                {
                    Console.Write("Startindex (0..{0}): ", input.Length - 1);
                    if(int.TryParse(Console.ReadLine(), out start) 
                       && start >= 0 
                       && start < input.Length)
                    {
                        validStart = true;
                    }
                    else
                    {
                        Console.WriteLine("Ungültiger Startindex!");
                    }
                }

                int length = 0;
                bool validLength = false;
                while(!validLength)
                {
                    Console.Write("Länge (> 0) oder '*': ");
                    string userLength = Console.ReadLine();

                    if(userLength == "*")
                    {
                        length = input.Length - start;
                        validLength = true;
                    }
                    else if(int.TryParse(userLength, out length) && length > 0 && (start + length) <= input.Length)
                    {
                        validLength = true;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Länge!");
                    }
                }

                string temp = "";
                for(int i = start; i < start + length; i++)
                {
                    temp += input[i];
                }

                Console.Write("Filter eingeben: ");
                string filter = Console.ReadLine();


                string output = "";
                for(int i = 0; i < temp.Length; i++)
                {
                    if(!containsChar(filter, temp[i]))
                    {
                        output += temp[i];
                    }
                }

                Console.WriteLine("Ergebnis: " + output);

                Console.Write("Geben Sie einen String ein (Enter beendet): ");
                input = Console.ReadLine();
            }
        }

        static bool containsChar(string input, char search)
        {
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == search)
                {
                    return true;
                }
            }
            return false;
        }
    }
}