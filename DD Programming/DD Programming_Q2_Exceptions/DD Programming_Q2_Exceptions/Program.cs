using System;

class Program
{
    static void Main()
    {
        // Uncomment the part you want to test by removing the comment slashes (//) and comment out the other parts similarly.

        // Part 1: Divide Two Numbers with Exception Handling
        
        try
        {
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            if (!double.TryParse(input1, out double number1))
            {
                throw new FormatException("Input is not a valid number.");
            }

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double number2))
            {
                throw new FormatException("Input is not a valid number.");
            }

            double result = number1 / number2;
            Console.WriteLine($"Result of division: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format exception: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Divide by zero exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        

        // Part 2: Convert String to Integer with Exception Handling
        
        try
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            
            if (!int.TryParse(input, out int number))
            {
                throw new FormatException("Input is not a valid integer.");
            }

            Console.WriteLine($"Parsed number: {number}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        

        // Part 3: Divide Method with DivideByZeroException Handling
        
        try
        {
            Console.Write("Enter the numerator: ");
            int numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter the denominator: ");
            int denominator = int.Parse(Console.ReadLine());

            double result = Divide(numerator, denominator);
            Console.WriteLine($"Result of division: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Divide by zero exception: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        

        // Part 4: Convert String to Uppercase with NullReferenceException Handling
        
        try
        {
            Console.Write("Enter a string (or leave empty for null): ");
            string input = Console.ReadLine();
            
            string result = ConvertToUppercase(input);
            Console.WriteLine($"Uppercase string: {result}");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Null reference exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        

        // Function for Part 3
        
        static double Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            
            return (double)numerator / denominator;
        }
        

        // Function for Part 4
        
        static string ConvertToUppercase(string input)
        {
            return input.ToUpper();
        }
        
    }
}
