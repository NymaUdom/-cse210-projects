using System;

namespace EternalQuestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize and start the goal manager
            GoalManager goalManager = new GoalManager();
            goalManager.Start();

            bool exit = false;
            while (!exit)
            {
                // Display menu options
                Console.WriteLine("\nEternal Quest Program Menu:");
                Console.WriteLine("1. Display player info");
                Console.WriteLine("2. List all goals");
                Console.WriteLine("3. Create a new goal");
                Console.WriteLine("4. Record an event");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        goalManager.DisplayPlayerInfo();
                        break;
                    case "2":
                        goalManager.ListGoals();
                        break;
                    case "3":
                        Console.Write("Enter goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter goal description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter points: ");
                        int points = int.Parse(Console.ReadLine());
                        goalManager.CreateGoal(name, description, points);
                        break;
                    case "4":
                        Console.Write("Enter goal name: ");
                        string goalName = Console.ReadLine();
                        goalManager.RecordEvent(goalName);
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting Eternal Quest Program...");
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
// Implemented a Leveling Up System: Users can now level up based on their total points earned. 
// Upon leveling up, they receive additional bonuses such as extra points, badges, or unlocking new features.
// These features aim to make the Eternal Quest Program more immersive and motivating for users.