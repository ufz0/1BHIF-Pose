using System;

namespace donaldfriends
{
    class donaldfriends
    {
        static void Main()
        {
            string choice = "";
            
            Console.WriteLine("Bist du ein Hund ? (J/N)");
            choice = Console.ReadLine();
            choice = choice.ToLower();

            if(choice == "j")
            {
                Console.WriteLine("Du bist Goofy");
            }else if(choice == "n")
            {
                Console.WriteLine("Bist du eine Maus? (J/N)");
                choice = Console.ReadLine();
                choice = choice.ToLower();

                if(choice == "j")
                {
                    Console.WriteLine("Du bist Micky Maus!");
                }else if(choice == "n")
                {
                    Console.WriteLine("Bist du ein Kind? (J/N)");
                    choice = Console.ReadLine();
                    choice = choice.ToLower();
                    if(choice == "j")
                    {
                        Console.WriteLine("Du bist Tick, trick oder Tack");

                    }else if(choice == "n")
                    {
                        Console.WriteLine("Bist du Reich ? (J/N)");
                        choice = Console.ReadLine();
                        choice = choice.ToLower();
                        if(choice == "j")
                        {
                            Console.WriteLine("Du bist Dagobert Duck");
                        }else
                        {
                            Console.WriteLine("Du bist Donald Duck!");
                        }
                    }
                }
            }
        }
    }
}