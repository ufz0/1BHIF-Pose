/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas, 15.10.2024
 *------------------------------------------------------
    Description:
        
 *------------------------------------------------------
*/

namespace currencyTranslator
{
    class currencyTranslator
    {
        static void Main()
        {
            const double EUR_TO_USD = 1.09;
            const double USD_TO_EUR = 0.92;

            const double CHF_TO_EUR = 1.06;
            const double EUR_TO_CHF = 0.94;

            const double USD_TO_CHF = 0.86;
            const double CHF_TO_USD = 1.16;


            Console.WriteLine("Enter the currency you want to convert from (E, D, F): ");
            String fromCurrency = Console.ReadLine();
            fromCurrency = fromCurrency.ToLower();

            Console.Write($"Enter the amount of {fromCurrency} you want to convert: ");
            double fromAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the currency you to convert to (E, D, F): ");
            String toCurrency = Console.ReadLine();
            toCurrency = toCurrency.ToLower();

            double value = 0;
            
            switch((fromCurrency, toCurrency))
            {
                case ("e", "d"):
                    value = fromAmount * EUR_TO_USD;
                    break;
                case("e", "f"):
                    value = fromAmount * EUR_TO_CHF;
                    break;
            
                case ("d", "e"):
                    value = fromAmount * USD_TO_EUR;
                    break;

                case("f", "f"):
                    value = fromAmount * USD_TO_CHF;
                    break;

                case("f", "e"):
                    value = fromAmount * CHF_TO_EUR;
                    break;

                case("f", "d"):
                    value = fromAmount * CHF_TO_USD;
                    break;
                
                default:
                    Console.WriteLine("Error: invalid input!");
                    break;
            }

            Console.WriteLine($"Converted Value: {toCurrency} {value}");

        }
    }
}