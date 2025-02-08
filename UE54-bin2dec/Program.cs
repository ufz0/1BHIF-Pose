/*------------------------------------------------------
    HTBLA-Leonding / Class: 1BHIF
 *------------------------------------------------------
    Lukas Leutgeb, 08.02.2025
 *------------------------------------------------------
    Description:
        A program to convert numbers from decimal to binary
 *------------------------------------------------------
*/  

using System;

class Program
{
    static void Main()
    {
        string binaryInput;
        int decimalValue = 0;
        
        
        do
        {
            Console.Write("Geben Sie eine Binärzahl ein: ");
            binaryInput = Console.ReadLine();
        } 
        while (!IsValidBinary(binaryInput));
        
        
        int power = 1; 
        for (int i = binaryInput.Length - 1; i >= 0; i--)
        {
            if (binaryInput[i] == '1')
            {
                decimalValue += power;
            }
            power *= 2;
        }
        
        
        Console.WriteLine($"Die Dezimalzahl ist: {decimalValue}");
    }


    static bool IsValidBinary(string input)
    {
        foreach (char c in input)
        {
            if (c != '0' && c != '1')
            {
                Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige Binärzahl ein.");
                return false;
            }
        }
        return true;
    }
}
