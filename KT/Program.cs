using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose conversion:");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        int choice = Int32.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter temperature in Celsius:");
                double celsiusInput = double.Parse(Console.ReadLine());
                ConvertToFahrenheit(celsiusInput);
                break;
            case 2:
                Console.WriteLine("Enter temperature in Fahrenheit:");
                double fahrenheitInput = double.Parse(Console.ReadLine());
                ConvertToCelsius(fahrenheitInput);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    static void ConvertToFahrenheit(double celsius)
    {
        double fahrenheit = (celsius * 9) / 5 + 32;
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
    }

    static void ConvertToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Celsius: {celsius}");
    }
}