/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas, 22.10.2024
 *------------------------------------------------------
    Description:
        A program to "calculate" what grade the user gets based on his podoubles.
 *------------------------------------------------------
*/


using System;

namespace percenttograde
{
    class percenttograde
    {
        static void Main()
        {
            double points;
            int grade = 0;


            Console.Write("Enter the amount of points you got: ");
            points = double.Parse(Console.ReadLine());

            switch((points))
            {
                case >= 88:
                    grade = 1;
                    break;

                case double n when(n >= 75 && n < 88):
                    grade = 2;
                    break;
                
                case double n when (n>=65 && n<75):
                    grade = 3;
                    break;

                case double n when (n >= 50 && n < 63):
                    grade = 4;
                    break; 
                case double n when(n >= 0 && n <= 50):
                    grade = 5; 
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.WriteLine("Note: " + grade);
        }
    }
}