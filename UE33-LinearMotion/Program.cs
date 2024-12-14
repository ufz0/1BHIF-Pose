using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the distance (km, > 0): ");
        int distance = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the speed of Car A (km/h, > 0): ");
        int velocityA = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the speed of Car B (km/h, > 0): ");
        int velocityB = int.Parse(Console.ReadLine());

        if (distance <= 0 || velocityA <= 0 || velocityB <= 0)
        {
            Console.WriteLine("All values must be greater than 0!");
            return;
        }

        double moveA = velocityA / 60.0;
        double moveB = velocityB / 60.0;
        double totalMovePerMinute = moveA + moveB;
        double totalTimeRequired = (double)distance / (velocityA + velocityB);

        Console.WriteLine("\nMinute | Distance");
        Console.WriteLine("--------------------");

        int minute = 0;
        int initialDistance = distance;

        while (distance > 0)
        {
            Console.WriteLine($"{minute,6} | {distance,10:F1} km");
            distance -= (int)totalMovePerMinute;
            minute++;
        }

        Console.WriteLine("\nMeeting point reached!");

        int hours = (int)totalTimeRequired;
        int minutes = (int)((totalTimeRequired - hours) * 60);
        int seconds = (int)(((totalTimeRequired - hours) * 60 - minutes) * 60);

        double distanceTraveledByA = velocityA * totalTimeRequired;
        double distanceTraveledByB = velocityB * totalTimeRequired;

        Console.WriteLine($"Exact time duration: {hours} hours, {minutes} minutes, {seconds} seconds");
        Console.WriteLine($"Car A traveled: {distanceTraveledByA:F2} km");
        Console.WriteLine($"Car B traveled: {distanceTraveledByB:F2} km");
        Console.WriteLine($"Total distance traveled: {initialDistance - distance} km");
    }
}
