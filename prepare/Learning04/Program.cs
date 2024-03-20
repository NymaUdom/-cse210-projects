using System;

namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new WritingAssignment
            WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

            // Get the summary of the assignment
            string summary = writingAssignment.GetSummary();

            // Get the writing information for the assignment
            string writingInfo = writingAssignment.GetWritingInformation();

            // Display the summary and writing information
            Console.WriteLine(summary);
            Console.WriteLine(writingInfo);
        }
    }
}
