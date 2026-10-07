using System;

class Program
{
    static void Main()
    {
        // Sample birthdate; replace with your own date of birth.
        DateTime birthdate = new(2000, 1, 1);
        DateTime currentDateTime = DateTime.Now;
        TimeSpan elapsed = currentDateTime - birthdate;
        double ageInYears = elapsed.TotalDays / 365.2425;

        Console.WriteLine($"Birthdate: {birthdate:d}");
        Console.WriteLine($"Current date and time: {currentDateTime}");
        Console.WriteLine($"Age: {ageInYears:F2} years");
        Console.WriteLine($"Birthdate plus 10 days: {birthdate.AddDays(10):d}");
    }
}
