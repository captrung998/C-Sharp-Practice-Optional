using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Uncomment the part you want to test by removing the comment slashes (//) and comment out the other parts.

        // Part 1: Divide two numbers and handle exceptions
        
        try
        {
            int numerator = 10;
            int denominator = 0;
            int result = numerator / denominator;  // This line may throw DivideByZeroException
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Divide by zero exception: {ex.Message}");
        }
        

        // Part 2: Convert a string to an integer and handle exceptions
        
        try
        {
            string input = "abc";
            int number = int.Parse(input);  // This line may throw FormatException
            Console.WriteLine($"Parsed number: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format exception: {ex.Message}");
        }
        

        // Part 3: Open a file and handle exceptions
        
        try
        {
            string filePath = "nonexistentfile.txt";
            StreamReader reader = new StreamReader(filePath);  // This line may throw FileNotFoundException
            Console.WriteLine($"File contents: {reader.ReadToEnd()}");
            reader.Close();
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File not found exception: {ex.Message}");
        }
        

        // Part 4: Read input from the user and handle exceptions
        
        try
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);  // This line may throw FormatException
            Console.WriteLine($"Entered number: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format exception: {ex.Message}");
        }
        

        // Part 5: Perform a calculation and handle exceptions
        
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b;  // This line may throw DivideByZeroException
            Console.WriteLine($"Result of calculation: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Divide by zero exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        
    }
}
