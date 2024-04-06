using System;

namespace StoryHub
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a user
            User user = new User("nyma_pax", "password123", "nyma@example.com");

            // Creating a story
            Story story = new Story("My Journey", "This is my story...", user);

            // Submitting the story
            user.SubmitStory(story);

            // Displaying submitted stories
            Console.WriteLine($"Submitted Stories by {user.Username}:");
            foreach (var submittedStory in user.SubmittedStories)
            {
                Console.WriteLine($"Title: {submittedStory.Title}, Content: {submittedStory.Content}");
            }

            // Approving the story
            user.ApproveStory(story);

            // Displaying approved stories
            Console.WriteLine($"\nApproved Stories by {user.Username}:");
            foreach (var approvedStory in user.ApprovedStories)
            {
                Console.WriteLine($"Title: {approvedStory.Title}, Content: {approvedStory.Content}");
            }
        }
    }
}