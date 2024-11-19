using System;

// 1, 3, 5, 7, 8, 10, 12 - 31 days
// 4, 6, 9, 11 - 30 days


namespace quarterCalculator
{
    class quarterClaculator 
    {
        static void Main()
        {
            bool isValidDate = true;
            bool isLeapYear = false;

            Console.WriteLine("Please enter a date: ");

            Console.WriteLine("Year: ");
            int years = int.Parse(Console.ReadLine());

            Console.WriteLine("Month: ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Day: ");
            int days = int.Parse(Console.ReadLine());

            if(years < 0)
            {
                isValidDate = false;
            }

            if(years % 4 == 0)
            {
                isLeapYear = true;
            }else if(years % 100 == 0)
            {
                isLeapYear = false;
            }else if(years % 400 == 0)
            {
                isLeapYear = true;
            }


            if(!isLeapYear && month == 2 && days > 28)
            {
                isValidDate = false;
            }
            if(isLeapYear && month == 2 && days > 29)
            {
                isValidDate = false;
            }
            
            if(month % 2 != 0 && month < 8 || month % 2 == 0 && month > 7)
            {
                if(days > 30)
                {
                    isValidDate = false;
                }
            }    


            if(isValidDate)
            {
                Console.WriteLine("The date is valid");
            }
            else
            {
                Console.WriteLine("The date is invalid");
            }
            


        }
    }
}