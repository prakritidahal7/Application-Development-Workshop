using System;

class Circle
{
    public const double PI = 3.14;

    public static double CalculateArea(double radius) => PI * radius * radius;
    public static double CalculatePerimeter(double radius) => 2 * PI * radius;
}

class Program
{
    static void Main()
    {
        // Uncommenting the next line causes CS0131: a constant is read-only after compilation.
        // Circle.PI = 3.14159;

        double radius = 5;
        Console.WriteLine($"PI: {Circle.PI}");
        Console.WriteLine($"Area (radius {radius}): {Circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter (radius {radius}): {Circle.CalculatePerimeter(radius)}");
        Console.WriteLine("PI is a constant: its value is fixed at compile time and cannot be reassigned.");
    }
}
