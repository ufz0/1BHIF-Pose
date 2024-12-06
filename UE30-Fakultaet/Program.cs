using System;
namespace FactorialCalculator {

    static class Program {

        public static void Main(string[] args) {
            Console.WriteLine("Enter a value for factorial calculation (int only):");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine($"The factorial of {userInput} is: {Factorial(userInput)}");
        }

        public static int Factorial(int x) => x > 0 ? x * Factorial(x - 1) : 1;
    }
}
