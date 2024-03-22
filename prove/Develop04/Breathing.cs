using System;

namespace MindfulnessProgram
{
    public class Breathing : Activity
    {
        public Breathing() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public override void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine("Starting breathing exercise...");

            for (int i = 0; i < _duration; i += 2)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(2);

                Console.WriteLine("Breathe out...");
                ShowCountDown(2);
            }

            DisplayEndingMessage();
        }
    }
}

