using System;
using System.IO.IsolatedStorage;


namespace cashmashine
{
    class Program
    {
        static void Main()
        {
            const int pin = 1234;
            const int balance = 1000;
            const int attempts = 0;
            const int maxAttempts = 3;
            const int mashineBalance = 10000;
            const int overdraftlimit = 100;



            Console.WriteLine("Enter your pin code: ");
            int enteredPin = int.Parse(Console.ReadLine());

            while(enteredPin != pin && attempts < maxAttempts)
            {
                Console.WriteLine("Wrong! You have", maxAttempts - attempts, "attempts left");  
                Console.WriteLine("Try again: ");
                enteredPin = int.Parse(Console.ReadLine());              
            }

            if(enteredPin == pin)
            {
                Console.WriteLine("How much money do you want to withdraw?");
                int withAmount = int.Parse(Console.ReadLine());
                if(withAmount > balance)
                {
                    if(withAmount < overdraftlimit)
                    {
                        Console.WriteLine("You are overdrafting your account, right now, do you want to proceed? (J/N)");
                        bool isOverDrafting = Console.ReadLine() == "J";
                        if(isOverDrafting)
                        {
                            Console.WriteLine("Alright, you will overdraft your accuont now.");
                        }else
                        {
                            Console.WriteLine("OK! Stopping withdrawel now…");
                        }
                    }else
                    {
                        Console.WriteLine("You don't have that much money");
                        return;
                    }

                }
                if(withAmount > mashineBalance)
                {
                    Console.WriteLine("The Cash Mashine doesn't have that much money in it");
                    return;
                }
                Console.WriteLine($"You withdrew {withAmount} from your bank account. Your new Balance is: {balance - withAmount}");
                

            }else
            {
                Console.WriteLine("Too many wrong tries, please try again later");
            }



        }
    }
}