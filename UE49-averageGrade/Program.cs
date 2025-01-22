using System;

namespace averageGrade
{
    class Program
    {
        static void Main()
        {
            int gradesSum = 0;
            int gradesAmount = 0;
            double average;
            bool pass = true;
            int grade;
            Console.WriteLine("Please enter 5 grades: ");

            for(int i = 1; i <= 5; i++)
            {
                
                Console.Write($"Grade {i}: ");
                grade = int.Parse(Console.ReadLine() ?? string.Empty);
                
                if(grade < 1 || grade > 5)
                {
                    Console.WriteLine("You have entered a invalid grade!");
                    return;
                }
                if(grade == 5)
                {
                    pass = false;
                }
                gradesSum += grade;
                gradesAmount++;
            }  
            
            
            if(pass)
            {
                average = gradesSum / gradesAmount;
                Console.WriteLine("You did pass with an average of: "+average);
                switch(average)
                {
                    case <= 1.40:
                        Console.WriteLine("Super, mit Auszeichnung bestanden!");
                        break;
                    case <= 1.60:
                            Console.WriteLine("<= 1.60");
                        break;
                    case <= 1.80:
                        Console.WriteLine("<= 1.80");
                        break;
                    case <= 2.0:
                        Console.WriteLine("Bravo, mit gutem Erfolg bestanden!");
                        break;
                }
            }else
            {
                Console.WriteLine("Sorry, you didn't pass");
            }
            
        }
    }
}