/*-----------------------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *-----------------------------------------------------------------------
    Leutgeb Lukas
 *-----------------------------------------------------------------------
    Description:
        A simple piggy bank program, to add some numbers together
 *-----------------------------------------------------------------------
*/




namespace piggyBank
{
    class piggyBank
    {
        static void Main()
        {
            Console.WriteLine("How many 50c pieces?");
            double cents_amount = double.Parse(Console.ReadLine());
            double toCent = cents_amount *0.01;

            Console.WriteLine("How many 1 euro pieces?");
            int one_euros_amount = int.Parse(Console.ReadLine());

            Console.WriteLine("How many 2 euro peices?? ");
            int two_euros_amount = int.Parse(Console.ReadLine());

            double sum = 50*toCent + one_euros_amount + two_euros_amount * 2;

            Console.WriteLine($"You now have {sum:f2}€ in your piggy bank");

        }
    }
}