using System;

class Program
{
    static void Main()
    {
        byte byteValue = 200;
        short shortValue = 32000;
        int intValue = 42;
        long longValue = 9_000_000_000L;
        float floatValue = 1.25f;
        double doubleValue = 2.71828;
        decimal decimalValue = 19.99m;
        char charValue = 'A';
        bool boolValue = true;

        string integerAsString = intValue.ToString();
        double parsedDouble = double.Parse("3.14");

        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"bool: {boolValue}");
        Console.WriteLine($"string (int 42 converted): {integerAsString}");
        Console.WriteLine($"double (\"3.14\" converted): {parsedDouble}");
    }
}
