/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas, 08.10.2024
 *------------------------------------------------------
    Description:
          A (fully functional) calculator 
 *------------------------------------------------------
*/
using System;

namespace calculator
{
    class calculator
    {
        static void Main()
        {
            

            double result = 0;

            Console.WriteLine("Simple calculator\n============");
            
            Console.Write("First Operand [double]:");
            double firstOperand = double.Parse(Console.ReadLine());

            Console.Write("Operation [*, /, +, -]: ");
            String operation = Console.ReadLine();

            Console.Write("Second operand [double]: ");
            double secondOperand = double.Parse(Console.ReadLine());


            if(operation == "*")
            {
                result = firstOperand * secondOperand;
                
            }else if(operation == "/")
            {

                if(secondOperand == 0)
                {
                    Console.WriteLine("Invalid: Can't devide by zero");
                    return;
                }
                result = firstOperand / secondOperand;

            }else if(operation == "+")
            {
                result = firstOperand + secondOperand;

            }else if(operation == "-")
            {
                result = firstOperand - secondOperand;

            }else
            {
                Console.WriteLine("Invalid input.");
            }


            Console.WriteLine($"{firstOperand} {operation} {secondOperand} = {result}");

        }
    }
}