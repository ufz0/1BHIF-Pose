namespace logatrithmusdualis
{
    class Program
    {
        static void Main()
        {
            int input;
            int count = 0;

            Console.WriteLine("Enter a number: ");
            input = int.Parse(Console.ReadLine());

            while(input >= 1) 
            {
                input = input / 2;
                count++;
            }

            Console.WriteLine("Amount that the number can be divided by 2: " + count);
        }
    }
}