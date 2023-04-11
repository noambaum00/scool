using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Create a new Game object using the constructor
        Game myGame = new Game("Super Mario Bros", 6, 1000, 50);

        // Print the string representation of the Game object
        Console.WriteLine(myGame.ToString());

        // Print the percentage of errors in the sales
        Console.WriteLine($"Error Percentage: {myGame.ErrorPercentage}%");

    }



    // Game class represents a video game
    public class Game
    {
        // Properties
        public string Name { get; }             // Name of the game
        public string Code { get; }             // Code of the game
        public int MinimumAge { get; }          // Minimum age required to play the game
        public int SalesCount { get; }          // Number of sales for the game
        public int ErrorCount { get; private set; } // Number of errors in the game

        // Constructor
        public Game(string name, int minimumAge, int salesCount, int errorCount)
        {
            Name = name;
            MinimumAge = minimumAge;
            SalesCount = salesCount;
            ErrorCount = errorCount;

            // Generate a unique code for the game based on the game name and current timestamp
            Code = $"{name.Substring(0, 3)}-{DateTime.Now.ToString("MMddyyyy")}";
        }

        // Computed property
        // Returns the percentage of errors in the sales
        public double ErrorPercentage
        {
            get { return (double)ErrorCount / SalesCount * 100; }
        }

        // Adds the given number of errors to the game
        public void AddError(int errorCount)
        {
            ErrorCount += errorCount;
        }

        // Overrides the ToString method to provide a string representation of the Game object
        public override string ToString()
        {
            return $"{Name} ({Code}) - Minimum Age: {MinimumAge} - Sales Count: {SalesCount} - Error Count: {ErrorCount}";
        }
    }

}