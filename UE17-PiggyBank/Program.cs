/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas, 22.10.2024
 *------------------------------------------------------
    Description:
        A piggy bank program
 *------------------------------------------------------
*/

using System;

namespace piggyBank
{
    class piggyBank
    {
        static void Main()
        {
            int twentyCents;
            int fiftyCents;
            int oneEuros;
            int twoEuros;

            double sum; 

            Console.Write("How many twenty cent pieces ? ");
            twentyCents = int.Parse(Console.ReadLine());

            Console.Write("How many fifty cent pieces ? ");
            fiftyCents = int.Parse(Console.ReadLine());

            Console.Write("How many one Euro pieces? ");
            oneEuros = int.Parse(Console.ReadLine());

            Console.Write("How much two euro pieces ? ");
            twoEuros = int.Parse(Console.ReadLine());

            sum = twentyCents * 0.2 + fiftyCents * 0.5 + oneEuros + twoEuros * 2;
            Console.WriteLine($"\n\nThere are {sum:f2}€ in the piggy bank");


            String stringNum = sum.ToString();
            stringNum.Split(",");


            Console.WriteLine($"Euro: {stringNum[0]}€\nCent: {stringNum[2]}c");
            
        }
    }
}