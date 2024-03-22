using System;

namespace MindfulnessProgram
{
    public abstract class Activity
    {
        protected string _activityName;
        protected int _duration;
        protected string _description;

        public Activity(string activityName, string description)
        {
            _activityName = activityName;
            _description = description;
        }

        public Activity()
        {
        }

        public virtual void DisplayStartingMessage()
        {
            Console.WriteLine($"Starting {_activityName}...");
            Console.WriteLine($"Description: {_description}");
            Console.Write("Enter duration in seconds: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready...");
            System.Threading.Thread.Sleep(3000); // Pause for 3 seconds
        }

        public virtual void DisplayEndingMessage()
        {
            Console.WriteLine($"Congratulations! You have completed {_activityName}.");
            Console.WriteLine($"Total time spent: {_duration} seconds");
            System.Threading.Thread.Sleep(3000); // Pause for 3 seconds
        }

        public void ShowSpinner(int seconds)
        {
            Console.WriteLine("Displaying spinner animation...");
            // Code for showing spinner animation
            System.Threading.Thread.Sleep(seconds * 1000); // Pause for specified seconds
        }

        public void ShowCountDown(int seconds)
        {
            Console.WriteLine($"Counting down from {seconds} seconds...");
            // Code for showing countdown animation
            for (int i = seconds; i >= 0; i--)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000); // Pause for 1 second
            }
        }

        public abstract void Run();
    }
}
