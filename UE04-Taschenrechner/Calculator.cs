/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas
 *------------------------------------------------------
    Description:
        A simple calculator to add 2 Numbers
 *------------------------------------------------------
*/
namespace calculator
{
   class calculator
   {
      static void Main()
      {

         Console.WriteLine("Enter the first number: ");
         int number1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter the 2nd Number:");
         int number2 = int.Parse(Console.ReadLine());

         int sum = number1 + number2;
         Console.WriteLine("\n\n");
         Console.WriteLine("Ergebnis:");
         Console.WriteLine("==============");
         Console.WriteLine($"  {number1}");
         Console.WriteLine($"+ {number2}");
         Console.WriteLine("---------------");
         Console.WriteLine(sum);
      }
   }
}