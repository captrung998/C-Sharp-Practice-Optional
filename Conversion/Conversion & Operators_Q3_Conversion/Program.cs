using System;

class Program
{
    static void Main()
    {
        // Uncomment the part you want to test by removing the comment slashes (//) and comment out the other parts.

        // Part 1: Calculate BMI using height in meters and weight in kilograms

        Console.Write("Enter your height in meters: ");
        double heightMeters = double.Parse(Console.ReadLine());

        Console.Write("Enter your weight in kilograms: ");
        double weightKg = double.Parse(Console.ReadLine());

        double bmi = weightKg / (heightMeters * heightMeters);
        Console.WriteLine($"Your BMI is {bmi:F1}");

        if (bmi < 18.5)
        {
            Console.WriteLine("You are Underweight");
        }
        else if (bmi < 25)
        {
            Console.WriteLine("You are Normal");
        }
        else if (bmi < 30)
        {
            Console.WriteLine("You are Overweight");
        }
        else
        {
            Console.WriteLine("You are Obese");
        }


        // Part 2: Calculate BMI using height in feet and inches, weight in pounds

        Console.Write("Enter your height in feet: ");
        int heightFeet = int.Parse(Console.ReadLine());

        Console.Write("Enter your height in inches: ");
        int heightInches = int.Parse(Console.ReadLine());

        Console.Write("Enter your weight in pounds: ");
        double weightLbs = double.Parse(Console.ReadLine());

        double heightInchesTotal = (heightFeet * 12) + heightInches;
        double bmi = (weightLbs * 703) / (heightInchesTotal * heightInchesTotal);
        Console.WriteLine($"Your BMI is {bmi:F1}");

        if (bmi < 18.5)
        {
            Console.WriteLine("You are Underweight");
        }
        else if (bmi < 25)
        {
            Console.WriteLine("You are Normal");
        }
        else if (bmi < 30)
        {
            Console.WriteLine("You are Overweight");
        }
        else
        {
            Console.WriteLine("You are Obese");
        }


        // Part 3: Convert integer score to double with one decimal place

        int playerScore = 100;
        double playerScoreDecimal = Convert.ToDouble(playerScore);
        Console.WriteLine($"Player's Score: {playerScoreDecimal:F1}");
        */

        // Part 4: Convert double health to integer percentage
        
        double playerHealth = 0.75;
        int playerHealthPercentage = (int)(playerHealth * 100);
        Console.WriteLine($"Player's Health as a percentage: {playerHealthPercentage}%");
        

        // Part 5: Convert double coins to integer (rounded down)
        
        double playerCoins = 123.45;
        int playerCoinsInteger = (int)playerCoins;
        Console.WriteLine($"Player's Coins as an integer: {playerCoinsInteger}");
        

        // Part 6: Convert boolean progress to string ("Completed" or "Incomplete")
        
        bool playerProgress = true;
        string progressStatus = playerProgress ? "Completed" : "Incomplete";
        Console.WriteLine($"Player's Progress as a string: {progressStatus}");
        
    }
}
