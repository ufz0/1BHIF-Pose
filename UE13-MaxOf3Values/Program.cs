/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Leutgeb Lukas, 15.10.2024
 *------------------------------------------------------
    Description:
        A program for finding the greatest of sume numbers
        It iterates through the list of items and finds the biggest one.
 *------------------------------------------------------
*/


namespace maxof3values
{
    class maxof3values
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int n3 = int.Parse(Console.ReadLine());



            int greatest = n3;

            if(n1 > n3)
            {
                greatest = n1;
            }
            if(n2 > n3)
            {
                greatest = n1;
            }

            Console.WriteLine($"Greatest: {greatest}");

        }
    }
}