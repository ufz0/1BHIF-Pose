/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 1BHIF
 *--------------------------------------------------------------
 *              Lukas Leutgeb, 08.10.2024
 *--------------------------------------------------------------
 * Description:
 * Auntolator, this program will calculate if you arrive in the right time.
 *--------------------------------------------------------------
*/


namespace visiting
{
    class visiting
    {
        static void Main()
        {
            double speed;
            double distance;
            double currentTime;

            Console.WriteLine("Auntolator (Aunt Calculator)\n========================================================");

            Console.Write("How fast are you going ?(km/h): ");
            speed = double.Parse(Console.ReadLine());

            Console.Write("How far is your aunt away? (km): ");
            distance = double.Parse(Console.ReadLine());


            Console.WriteLine("========================================================");
            // Calculate the time it takes and print it to the console.
            double travelTime = distance / speed;
            double arrivalTime = currentTime + travelTime;

            Console.WriteLine("\nAssuming your speed doesn't change: ");
            Console.WriteLine($"It will take about {travelTime} hours for you to got there.");
            Console.WriteLine($"You will be there at {arrivalTime:f2}\n");

            Console.WriteLine("==================\n");
            if(arrivalTime < 12)
            {
                Console.WriteLine("You will get a lunch.");
            }else
            {
                Console.WriteLine("You will only get coffee and cake.");
            }
            if(arrivalTime >= 19)
            {
                Console.Error.Write("Attention: it will get dark before you arrive!");
            }

            //For better readability in the terminal
            Console.WriteLine("\n");
        }
    }
}