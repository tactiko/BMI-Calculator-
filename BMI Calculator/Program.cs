using System;

namespace BMICalculator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the BMI Calculator :)");

        double weight = GetWeight();
        double height = GetHeight();

        double BMI = calculateBMI(weight, height);
        Console.WriteLine("Your Final BMI is:  " + Math.Round(BMI, 2));


    }
    static double GetWeight()
    {
        Console.WriteLine("Enter your weight in pounds: ");
        double weight = Double.Parse(Console.ReadLine());
        return weight;
    }
    static double GetHeight()
    {
        Console.WriteLine("Enter your height in feet and inches (ex. 5'7)\"): ");
        String input = Console.ReadLine();
        String[] split = input.Split("'");
        double feet = Double.Parse(split[0]);
        double inches = Double.Parse(split[1].Trim('"'));
        double height = (feet * 12) + inches;
        return height;
    }
    static double calculateBMI(double weight, double height)
    {
        // Conver inches into meters
        double meterHeight = height * 0.0254;
        // Convert weight into kilogram
        double kilogramWeight = weight * 0.453592;
        double bmi = kilogramWeight / (meterHeight *  meterHeight);
        return bmi;
    }
   
}

