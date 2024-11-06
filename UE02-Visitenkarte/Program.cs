/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas
 *------------------------------------------------------
    Description:
        Ein Visitenkarten erstellungsprogramm.
 *------------------------------------------------------
*/

namespace visitenkarte
{
    class Visitenkarte
    { 
        static void Main()
        {
            Console.Write("Gib deinen Namen ein: ");
            string? name = Console.ReadLine();

            Console.Write("\nGib deinen Wohnort ein: ");
            string wohnort = Console.ReadLine();

            PrintCard(name, wohnort);
        }
        static void PrintCard(string name, string wohnort)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("* Name: " + name);
            Console.WriteLine("* Wohnort: "+ wohnort );
            Console.WriteLine("***************************");
        }
    }
}