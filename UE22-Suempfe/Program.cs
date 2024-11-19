using System;


namespace celinischeSuempfe
{
    class Program
    {
        static void Main()
        {


            bool hasKnelt = false;
            bool isLoepsing = false;
            bool isManuseling = false;
            bool isNopeling = false;

            string stamm = "";
            bool playAgain = true;
            
            while(playAgain)
            {
                Console.WriteLine("Willkommen in den celinischen Sümpfen\n");
                
                Console.Write("Hat ihr celinishcer Freund einen Knelt ? (J/N) -->");
                hasKnelt = Console.ReadLine().ToLower() is "j" or "n";


                Console.Write("Loepst er womoeglich ? (J/N)               -->");
                isLoepsing = Console.ReadLine().ToLower() is "j" or "n";


                Console.Write("Manuselt er? (J/N)                         -->");
                isManuseling = Console.ReadLine().ToLower() is "j" or "n";
            
                

                Console.Write("Nopelt er? (J/N)                           -->");
                isNopeling = Console.ReadLine().ToLower() is "j" or "n";


                if(hasKnelt && isManuseling)
                {
                    stamm = "Asis";
                }
                if(hasKnelt && !isManuseling && isNopeling)
                {
                    stamm = "Cedi";
                }
                if(hasKnelt && !isManuseling && !(isNopeling))
                {
                    stamm = "Drudi";
                }
                if(!hasKnelt && !isManuseling && isNopeling)
                {
                    stamm = "Bela";
                }
                if(!hasKnelt && isManuseling && isLoepsing && !isNopeling)
                {
                    stamm = "Cedi";
                }
                if(!hasKnelt && !isManuseling && isLoepsing && !isNopeling)
                {
                    stamm = "Drudi";
                }
                if(!hasKnelt && isManuseling && !isLoepsing && !isNopeling)
                {
                    stamm = "Drudi";
                }
                if(!hasKnelt && !isManuseling && !isLoepsing && !isNopeling)
                {
                    stamm = "Cedi";
                }

                
                if(stamm == "Asi")
                {
                    Console.WriteLine($"Ein {stamm}. Gratuliere!");
                }
                else if(stamm == "Bela")
                {
                    Console.WriteLine("Beachtlich, ein Bela!");
                }else if(stamm == "Cedi")
                {
                    Console.WriteLine("Ein Cedi... naja...");
                }else if(stamm == "Drudi")
                {
                    Console.WriteLine("Ein Drudi, um Himmelswillen!");
                }else 
                {
                    Console.WriteLine("Ein Gespenst, das ist nicht möglich!");
                }
                Console.WriteLine("Wollen sie eine neue Testung? (J/N)");
                playAgain = Console.ReadLine().ToLower() is "j" or "n";
            }
        }
    }
}