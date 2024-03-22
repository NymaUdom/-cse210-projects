using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public class Listing : Activity
    {
        private List<string> _prompts;

        public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        public override void Run()
        {
            DisplayStartingMessage();
            Random rand = new Random();
            string randomPrompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine(randomPrompt);
            Console.WriteLine("Starting listing...");
            ShowCountDown(_duration);
            Console.WriteLine($"You listed {_duration} items.");
            DisplayEndingMessage();
        }
    }
}

