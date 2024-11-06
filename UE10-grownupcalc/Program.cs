/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 1BHIF
 *--------------------------------------------------------------
 *              Lukas Leutgeb, 08.10.2024
 *--------------------------------------------------------------
 * Description:
 * A simple calculator to detecti f the users young enough to use this
 *--------------------------------------------------------------
*/

using System;

namespace grownupCalc
{
    class guc
    {
        static void Main()
        {
            const int GROWN_UP_AT = 18;
            int age;
            while(true)
            {
                try
                {
                    Console.WriteLine("Please enter your current age: ");
                    age = int.Parse(Console.ReadLine());
                    break;
                }catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }
            }
            
            if(age > 18)
            {
                Console.WriteLine("You are too old to use this software, sorry ;(");
            }else if(age < 18)
            {
                Console.WriteLine("You are young enough to use this :)");
            }else if(age == 50)
            {
                Console.WriteLine("Congratulations, you are halfway there! :=) ");
            }else if(age == 25)
            {
                Console.WriteLine("You already have lived ¼ of your life :D");
            }
            
            else
            {
                Console.WriteLine("You shouldn't see this 😲");
            }
        }
    }
}