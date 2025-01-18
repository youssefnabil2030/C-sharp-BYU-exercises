using System;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirement 1: Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();

        // Parse the input as an integer
        int gradePercentage = int.Parse(input);

        // Initialize variables for letter grade and sign
        string letter = "";
        string sign = "";

        // Core Requirement 2: Determine the letter grade using if statements
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Core Requirement 3: Check if the user passed and print a message
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep trying for next time.");
        }

        // Stretch Challenge 1: Add "+" or "-" to the grade
        if (gradePercentage >= 60 && letter != "A" && letter != "F")
        {
            int lastDigit = gradePercentage % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Stretch Challenge 2: Handle exceptions for A+, F+, and F-
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+ grade
        }

        if (letter == "F")
        {
            sign = ""; // No F+ or F-
        }

        // Final output
        Console.WriteLine($"Your letter grade is: {letter}{sign}");
    }
}
