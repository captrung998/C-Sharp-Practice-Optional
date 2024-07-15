using System;

class Program
{
    static void Main()
    {
        // Uncomment the part you want to test by removing the comment slashes (//) and comment out the other parts.

        // Part 1: Concatenating two strings (player's first and last name)

        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;
        Console.WriteLine("Concatenated name: " + fullName);


        // Part 2: Getting strings from the user (for username)

        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();

        string fullName = firstName + " " + lastName;
        Console.WriteLine("Concatenated name: " + fullName);


        // Part 3: Concatenating three strings (including clan name)

        string firstName = "John";
        string lastName = "Doe";
        string clanName = "DragonSlayers";

        string playerInfo = firstName + " " + lastName + " from " + clanName;
        Console.WriteLine("Player info: " + playerInfo);


        // Part 4: Concatenating a string and an integer (player name with numbers)

        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();

        Console.Write("Enter your player number: ");
        int playerNumber = int.Parse(Console.ReadLine());

        string playerInfo = playerName + playerNumber;
        Console.WriteLine("Player info: " + playerInfo);

    }
}
