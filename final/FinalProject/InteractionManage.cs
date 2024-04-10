namespace StoryHub
{
    class InteractionManager
    {
        // Member Variables
        private List<string> comments;
        private List<int> ratings;
        private List<string> discussions;

        // Constructor
        public InteractionManager()
        {
            comments = new List<string>();
            ratings = new List<int>();
            discussions = new List<string>();
        }

        // Method to allow users to comment on stories
        public void Comment(string comment)
        {
            comments.Add(comment);
            Console.WriteLine($"Comment added: \"{comment}\"");
        }

        // Method to allow users to rate stories
        public void Rate(int rating)
        {
            ratings.Add(rating);
            Console.WriteLine($"Rating added: {rating}");
        }

        // Method to facilitate discussions among users based on stories
        public void Discuss(string discussion)
        {
            discussions.Add(discussion);
            Console.WriteLine($"Discussion started: \"{discussion}\"");
        }
    }
}
