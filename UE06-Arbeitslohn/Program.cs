/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas
 *------------------------------------------------------
    Description:
        A Program to calculate the salary per hour.
 *------------------------------------------------------
*/
namespace Arbeitslohn
{
    class Arbeitslohn
    {
        static void Main()
        {
            Console.WriteLine("Gib deinen Namen ein: ");
            String name = Console.ReadLine();
            
            Console.WriteLine("Wieviel Stunden hast du gearbeitet?");
            double workingHours = int.Parse(Console.ReadLine());

            Console.WriteLine("Wieviel hast du verdient?");
            double Salary = int.Parse(Console.ReadLine());

            Console.WriteLine("In welcher Wärhung hast du es verdient?");
            String currency = Console.ReadLine();


            double perHour = Salary/workingHours;
            Console.WriteLine($"{name} hat {workingHours} Stunden gearbeitet und dabei {Salary} verdient.");
            Console.WriteLine($"Das bedeutet, dass {name} {perHour}{currency} pro Stunde verdient hat.");
        }
    }
}