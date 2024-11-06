/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas
 *------------------------------------------------------
    Description:
        A Calculator to add 2 floating point numbers
 *------------------------------------------------------
*/

namespace FloatingCalc
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the 1st float number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 2n Float number: ");
            float num2 = float.Parse(Console.ReadLine());

            float sum = num1+num2;

            Console.WriteLine("\n\n");
            Console.WriteLine("Ergebnis:");
            Console.WriteLine("==============");
            Console.WriteLine($"  {num1}");
            Console.WriteLine($"+ {num2}");
            Console.WriteLine("---------------");
            Console.WriteLine(sum);

        }
    }
}