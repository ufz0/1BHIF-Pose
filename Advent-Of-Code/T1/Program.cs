using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // Get the current directory
        string scriptDir = Directory.GetCurrentDirectory();
        Directory.SetCurrentDirectory(scriptDir);

        string filePath = "input.txt";
        string inputValue = "";
        string[] inputSplit;
        List<int> numberArray;
        int totalResult = 0;

        // Get the input
        try
        {
            inputValue = File.ReadAllText(filePath);
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred while reading the file: " + e.Message);
            return;
        }

        inputSplit = inputValue.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

        foreach (var line in inputSplit)
        {
            numberArray = new List<int>();
            foreach (var letter in line)
            {
                if (int.TryParse(letter.ToString(), out int number))
                {
                    numberArray.Add(number);
                    Console.WriteLine(number);
                }
            }

            if (numberArray.Count > 0)
            {
                int lineResult = numberArray[0] * 10 + numberArray[numberArray.Count - 1];
                totalResult += lineResult;
            }
        }

        Console.WriteLine("Total Result: " + totalResult);
    }
}
