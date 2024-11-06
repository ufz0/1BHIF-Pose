/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas
 *------------------------------------------------------
    Description:
        A simple program for currency exchanging from euros
 *------------------------------------------------------
*/

using System.Diagnostics;

namespace ce
{
    class ce
    {
        static void Main()
        {

            Console.WriteLine("From what currency do you want to convert? (E)uro, (D)oller, (F)ranken");
            String fromCurrency = Console.ReadLine();
            fromCurrency = fromCurrency.ToLower();

            if(fromCurrency == "e")
            {
                Console.WriteLine("Enter the amount of euro:");
                double euroValue = double.Parse(Console.ReadLine());

                double chf = euroValue * 0.94;
                double dollers = euroValue * 1.11;
                double yen = euroValue * 158.99;
                Console.WriteLine("That's equal to:");
                Console.WriteLine($"{chf:f2} CHF");
                Console.WriteLine($"{dollers:f2} Doller");
                Console.WriteLine($"{yen:f2} Yen");

            }
            else if(fromCurrency == "d")
            {
                Console.WriteLine("Enter the amount of Dollers:");
                double dollerValue = double.Parse(Console.ReadLine());

                double euros = dollerValue * 0.90;
                double chf = dollerValue * 0.85;
                double yen = dollerValue * 143.37;

                Console.WriteLine($"{chf:f2} CHF");
                Console.WriteLine($"{euros:f2} Euros");
                Console.WriteLine($"{yen:f2} Yen");

            }
            else if(fromCurrency == "f"){
                Console.WriteLine("Enter the amount of CHF:");
                double CHF = double.Parse(Console.ReadLine());

                double euros = CHF * 1.07;
                double dollers = CHF * 1.18;
                double yen = CHF * 169.51;

                Console.WriteLine($"{euros:f2} Euros");
                Console.WriteLine($"{dollers:f2} Doller");
                Console.WriteLine($"{yen:f2} Yen");

            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}