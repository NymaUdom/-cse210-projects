using System;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mindfulness Program Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            bool exit = false;
            while (!exit)
            {
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Breathing breathingActivity = new Breathing();
                        breathingActivity.Run();
                        break;
                    case "2":
                        Reflection reflectionActivity = new Reflection();
                        reflectionActivity.Run();
                        break;
                    case "3":
                        Listing listingActivity = new Listing();
                        listingActivity.Run();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting Mindfulness Program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}



// Exceeding Requirements:
// Enhanced Animation: The breathing activity now includes dynamic text animation, with text that grows rapidly during inhalation and slows down during exhalation.
// This improvement provides a more engaging and realistic visual representation of the breathing exercise, enhancing the user experience.