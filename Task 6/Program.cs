using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new() { "Mango", "Apple", "Banana" };
        fruits.Add("Orange");
        fruits.Remove("Apple");

        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
            Console.WriteLine(fruit);

        Dictionary<int, string> fruitById = new()
        {
            [1] = "Mango",
            [2] = "Apple",
            [3] = "Banana"
        };
        fruitById.Add(4, "Orange");

        Console.WriteLine("Fruit dictionary:");
        foreach (KeyValuePair<int, string> entry in fruitById)
            Console.WriteLine($"ID {entry.Key}: {entry.Value}");
    }
}
