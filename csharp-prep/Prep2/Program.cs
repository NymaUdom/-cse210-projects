using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user for grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Determine letter grade
        string letter;
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

        // Determine pass or fail
        string passStatus = (gradePercentage >= 70) ? "Pass" : "Fail";

        // Display the result
        Console.WriteLine($"Your letter grade is {letter} and you {passStatus} the course.");

        // Stretch Challenge: Determine the sign (+/-)
        string sign = "";
        int lastDigit = gradePercentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3 && gradePercentage >= 60)
        {
            sign = "-";
        }

        // Handle exceptional cases
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+ grade
        }
        else if (letter == "F")
        {
            sign = ""; // No F+ or F- grades
        }

        // Display the result with sign
        Console.WriteLine($"Your final grade is {letter}{sign}");
    }
}