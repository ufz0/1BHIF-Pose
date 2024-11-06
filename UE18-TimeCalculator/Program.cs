using System;

namespace timecalculator
{
    class timecalculator
    {
        static void Main()
        {
            int seconds = 0;
            int minutes = 0;
            int hours = 0;
            int days = 0;

            Console.WriteLine("Umrechner von Sekunden in Tage, Stunden, Minuten und Sekunden");
            Console.WriteLine("=============================================================\n");

            Console.Write("Gesamtsekunden [int]: ");
            seconds = int.Parse(Console.ReadLine());

/*             while(seconds >= 60)
            {
                if(seconds >= 60)
                {
                    seconds -= 60;
                    minutes += 1;
                }
                if(minutes >= 60)
                {
                    minutes -= 60;
                    hours += 1;
    
                }
                if(hours >= 24)
                {
                    hours -= 24;
                    days += 1;
                }
                
            } */

            days = seconds / 86400;
            hours = (seconds % 86400) / 3600;
            minutes = (seconds % 3600) / 60;

            seconds = seconds % 60;

            Console.WriteLine("Days: "+ days);
            Console.WriteLine("Hours: "+ hours);
            Console.WriteLine("Minutes: "+ minutes);
            Console.WriteLine("Seconds: " + seconds);

            Console.WriteLine("Umrechner von Sekunden in Tage, Stunden und Minuten");
            Console.WriteLine("===================================================");
            if (seconds < 60 )
            {
                Console.WriteLine($"{seconds} Sekunden bleiben {seconds} Sekunden");
            }
            else if (days == 0)
            {
                Console.WriteLine($"{seconds} Sekunden sind {hours} Stunden {minutes} Minuten und {seconds} Sekunden ");
            }
            else if (hours == 0)
            {
                Console.WriteLine($"{seconds} Sekunden sind {days} Tage {minutes} Minuten und {seconds} Sekunden ");
            }
            else if (minutes == 0)
            {
                Console.WriteLine($"{seconds} Sekunden sind {days} Tage und {seconds} Sekunden ");
            }
            else
            {
            Console.WriteLine($"{seconds} Sekunden sind {days} Tage {hours} Stunden {minutes} Minuten und {seconds} Sekunden ");
            }


            Console.WriteLine("Press a random key to quit");
            Console.ReadKey();
        }
    }
}