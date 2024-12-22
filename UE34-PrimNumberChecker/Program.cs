using System;


namespace primeNumber
{
    class Program
    {
        static void Main()
        {
            int primeCandidate;

            cwl("Enter the number to check");
            primeCandidate = int.Parse(crl());

            bool isPrime = primeCandidate >= 2;

            int divisor = 2;

            while(divisor < primeCandidate / 2 && isPrime)
            {
                if(primeCandidate % divisor == 0)
                {
                    isPrime = false;
                }
                divisor++;
            }
            cwl(isPrime ? "Prime" : "Not Prime");

        }


        static void cwl(String input)
        {
            Console.WriteLine(input);
        }

        static string crl()
        {
            return Console.ReadLine() ?? string.Empty;
        }
    }
    
}