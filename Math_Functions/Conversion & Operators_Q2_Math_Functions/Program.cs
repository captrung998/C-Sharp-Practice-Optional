using System;

class Program
{
    static void Main()
    {
        // Uncomment the part you want to test by removing the comment slashes (//) and comment out the other parts similarly.

        // Part 1: Minimum of two numbers
        
        Console.WriteLine("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double min = Math.Min(num1, num2);
        Console.WriteLine($"The minimum of {num1} and {num2} is {min}");
        

        // Part 2: Maximum of two numbers
        
        Console.WriteLine("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double max = Math.Max(num1, num2);
        Console.WriteLine($"The maximum of {num1} and {num2} is {max}");
        

        // Part 3: Square root of a number
        
        Console.WriteLine("Enter a number: ");
        double num = double.Parse(Console.ReadLine());
        double sqrt = Math.Sqrt(num);
        Console.WriteLine($"The square root of {num} is {sqrt}");
        

        // Part 4: Absolute value of a number
        
        Console.WriteLine("Enter a number: ");
        double num = double.Parse(Console.ReadLine());
        double abs = Math.Abs(num);
        Console.WriteLine($"The absolute value of {num} is {abs}");
        

        // Part 5: Power of a number
        
        Console.WriteLine("Enter the base number: ");
        double numBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the exponent: ");
        double exponent = double.Parse(Console.ReadLine());
        double result = Math.Pow(numBase, exponent);
        Console.WriteLine($"{numBase} raised to the power of {exponent} is {result}");
        

        // Part 6: Round a number to the nearest integer
        
        Console.WriteLine("Enter a number: ");
        double num = double.Parse(Console.ReadLine());
        double rounded = Math.Round(num);
        Console.WriteLine($"{num} rounded to the nearest integer is {rounded}");
        

        // Part 7: Smallest integer greater than or equal to a number (Ceiling)
        
        Console.WriteLine("Enter a number: ");
        double num = double.Parse(Console.ReadLine());
        double ceiling = Math.Ceiling(num);
        Console.WriteLine($"The smallest integer greater than or equal to {num} is {ceiling}");
        

        // Part 8: Largest integer less than or equal to a number (Floor)
        
        Console.WriteLine("Enter a number: ");
        double num = double.Parse(Console.ReadLine());
        double floor = Math.Floor(num);
        Console.WriteLine($"The largest integer less than or equal to {num} is {floor}");
        

        // Part 9: e raised to the power of a number
        
        Console.WriteLine("Enter a number: ");
        double num = double.Parse(Console.ReadLine());
        double exp = Math.Exp(num);
        Console.WriteLine($"e raised to the power of {num} is {exp}");
        

        // Part 10: Natural logarithm of a number
        
        Console.WriteLine("Enter a number: ");
        double num = double.Parse(Console.ReadLine());
        double log = Math.Log(num);
        Console.WriteLine($"The natural logarithm of {num} is {log}");
        

        // Part 11: Generate a random number between 1 and 100
        
        Random random = new Random();
        int randomNumber = random.Next(1, 101); // Generates a random integer between 1 and 100
        Console.WriteLine($"A random number between 1 and 100 is {randomNumber}");
        
    }
}
