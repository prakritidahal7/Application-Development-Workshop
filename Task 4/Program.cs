using System;

class Program
{
    static void Main()
    {
        int[] favoriteNumbers = { 7, 3, 21, 11, 5 };
        Array.Sort(favoriteNumbers);
        Array.Reverse(favoriteNumbers);

        Console.WriteLine("Numbers in descending order:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
            Console.WriteLine(favoriteNumbers[i]);

        int selectedNumber = 11;
        int index = Array.IndexOf(favoriteNumbers, selectedNumber);
        Console.WriteLine(index >= 0
            ? $"{selectedNumber} is at zero-based index {index}."
            : $"{selectedNumber} was not found.");
    }
}
