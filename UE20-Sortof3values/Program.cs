using System;

namespace sortof3Values
{
    class sortof3Values
    {
        static void Main()
        {
            int x1;
            int x2;
            int x3;
            int greatest = 0;
            int temp = 0;
            Console.WriteLine("Enter 3 numbers: ");
            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());

            
            if(x2 > x1)
            {
                temp = x1;
                x1 = x2;
                x2 = temp;
            }
            if(x3 > x1)
            {
                temp = x1;
                x1 = x3;
                x3 = temp; 
            }
            if(x3 > x2)
            {
                temp = x2;
                x2 = x3;
                x3 = temp;
            }

            Console.WriteLine("x1: " + x1);
            Console.WriteLine("x2: " + x2);
            Console.WriteLine("x3: " + x3);
        }
    }
}