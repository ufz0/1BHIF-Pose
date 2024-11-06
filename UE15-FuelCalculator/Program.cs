/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas, 22.10.2024
 *------------------------------------------------------
    Description:
    A program to let you know if you use too much fuel     
 *------------------------------------------------------
*/

using System;

namespace fuelCalc
{
    class fuelCalc
    {
        static void Main()
        {
            string fuelType = "";
            double km;
            double fuelUsed; 
            double averageUsage;

            Console.Write("What fueltype do you have? ");
            fuelType = Console.ReadLine().ToLower();

            Console.Write("How many km's did you drive?");
            km = double.Parse(Console.ReadLine());

            Console.WriteLine("How much fuel did you use?");
            fuelUsed = double.Parse(Console.ReadLine());


            averageUsage = (fuelUsed/km) * 100;
            
            if(km <= 0 || fuelUsed <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            switch(fuelType)
            {
                case "diesel":

                    switch(averageUsage)
                    {
                        case <5:
                            Console.WriteLine("Ihr Auto ist sparsam!");
                            break; 
                        case <= 6:
                            Console.WriteLine("Ihr Verbrauch ist im Normalbereich");
                            break;
                        case > 6:
                            Console.WriteLine("Sie haben einen hohen Kraftstoffverbauch");
                            break;

                    }
                    
                    break;


                case "benzin":

                    switch(averageUsage)
                    {
                        case < 6:
                            Console.WriteLine("hr Auto ist sparsam!");
                            break;
                        case <= 7:
                            Console.WriteLine("Ihr verbrauch ist im Normalbereich");
                            break;
                        case > 7:
                            Console.WriteLine("Sie haben einen erhöhten Kraftstoffverbrauch");
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }


            Console.WriteLine("Drücken sie eine beliebige Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}