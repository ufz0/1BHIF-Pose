using System;

namespace quartalChecker
{
    class quartalChecker
    {
        static void Main()
        {
            int quartal;
            bool isValidInput = false;
            int month = 0;
            //Hashmap + recursive functions

            while(!isValidInput)
            {
                Console.Write("Please enter your birth month as number: ");
                month = int.Parse(Console.ReadLine() ?? String.Empty);
                if(month > 0 && month <= 12)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid month...");
                }
            }
            



            if(month < 1 && month <= 4)
            {   
                quartal = 1;
            }
            else if(month > 4 && month <= 8)
            {
                quartal = 2;
            }
            else if(month > 8 && month <= 12)
            {
                quartal = 3;
            }
            else
            {
                quartal = 4;
            }
            Console.WriteLine($"You were born in the {quartal} quartal");
        }
    }
}