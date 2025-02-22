using System;

class Program
{
    static void Main()
    {
        // Get weight (kg)
        Console.Write("Enter your weight (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Get height (cm) and convert to meters
        Console.Write("Enter your height (cm): ");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        double heightM = heightCm / 100.0; // Convert cm to meters

        // Calculate BMI
        double bmi = weight / (heightM * heightM);

        // Display BMI result
        Console.WriteLine($"\nYour Body Mass Index (BMI) is: {bmi:F2}");

        if (bmi < 18.5)
        {
            Console.WriteLine("Category: Underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Category: Normal weight");
        }
        else if (bmi >= 25.0 && bmi <= 29.9)
        {
            Console.WriteLine("Category: Overweight");
        }
        else
        {
            Console.WriteLine("Category: Obesity");
        }

        // Wait for user input before exiting
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
