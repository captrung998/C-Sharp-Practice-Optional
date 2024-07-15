using System;

class Program
{
    static void Main()
    {
        // Uncomment the part you want to test by removing the comment slashes (//) and comment out the other parts.

        // Part 1: Add and subtract days from a date
        
        Console.Write("Enter the date (dd/MM/yyyy): ");
        DateTime inputDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Enter the number of days to add or subtract: ");
        int daysToAddOrSubtract = int.Parse(Console.ReadLine());

        DateTime dateAfter = inputDate.AddDays(daysToAddOrSubtract);
        DateTime dateBefore = inputDate.AddDays(-daysToAddOrSubtract);

        Console.WriteLine($"Date after {daysToAddOrSubtract} days: {dateAfter:dd/MM/yyyy}");
        Console.WriteLine($"Date before {daysToAddOrSubtract} days: {dateBefore:dd/MM/yyyy}");
        

        // Part 2: Calculate age based on date of birth
       
        Console.Write("Enter your date of birth (dd/MM/yyyy): ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        DateTime now = DateTime.Today;
        int age = now.Year - dob.Year;

        if (now < dob.AddYears(age))
        {
            age--;
        }

        int months = now.Month - dob.Month;
        if (months < 0)
        {
            months += 12;
        }

        int days = now.Day - dob.Day;
        if (days < 0)
        {
            days += DateTime.DaysInMonth(now.Year, now.Month);
            months--;
        }

        Console.WriteLine($"You are {age} years, {months} months, {days} days old");
     

        // Part 3: Calculate difference between two dates
     
        Console.Write("Enter the first date (dd/MM/yyyy): ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        Console.Write("Enter the second date (dd/MM/yyyy): ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

        TimeSpan difference = secondDate - firstDate;
        int differenceInDays = difference.Days;

        Console.WriteLine($"The difference between two dates is: {differenceInDays} days");
       

        // Part 4: Convert days into years, weeks, and days
       
        Console.Write("Enter the number of days: ");
        int totalDays = int.Parse(Console.ReadLine());

        int years = totalDays / 365;
        int weeks = (totalDays % 365) / 7;
        int days = (totalDays % 365) % 7;

        Console.WriteLine($"Years: {years}");
        Console.WriteLine($"Weeks: {weeks}");
        Console.WriteLine($"Days: {days}");
     

        // Part 5: Print day name of week for a given day number
      
        Console.Write("Enter the number of day (1-7): ");
        int dayNumber = int.Parse(Console.ReadLine());

        DayOfWeek dayOfWeek = (DayOfWeek)(dayNumber - 1); // Adjust dayNumber to DayOfWeek enum (Sunday is 0)

        Console.WriteLine($"Day: {dayOfWeek}");
       

        // Part 6: Retrieve the current date
       
        DateTime currentDate = DateTime.Today;
        Console.WriteLine($"The current date is: {currentDate:dd/MM/yyyy}");
      

        // Part 7: Retrieve the current date and time
       
        DateTime currentDateTime = DateTime.Now;
        Console.WriteLine($"The current date and time is: {currentDateTime:dd/MM/yyyy HH:mm:ss}");
      
    }
}
