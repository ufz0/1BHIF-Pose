/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas, 22.10.2024
 *------------------------------------------------------
    Description:
        A calculator, using switch 
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


            switch(operation)
            {
                case "+":
                    result = firstOperand + secondOperand;
                    break;
                case "-":
                    result = firstOperand - secondOperand;
                    break;
                case "*":
                    result = firstOperand * secondOperand;
                    break;
                case "/":
                    if(secondOperand == 0)
                    {
                        Console.WriteLine("Error: Can't devide by zero");
                        return;
                    }
                    result = firstOperand / secondOperand;
                    break;
            }

            Console.WriteLine($"{firstOperand} {operation} {secondOperand} = {result}");
        }
    }
}