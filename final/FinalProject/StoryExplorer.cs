namespace StoryHub
{
    class StoryExplorer
    {
        // Member Variables
        private List<string> categories;
        private List<string> tags;

        // Constructor
        public StoryExplorer()
        {
            categories = new List<string>();
            tags = new List<string>();
        }

        // Behaviors (Methods)
        public void ExploreByCategory(string category)
        {
            Console.WriteLine($"Exploring stories by category: \"{category}\"");
            // Placeholder for allowing users to explore stories based on categories
        }

        public void ExploreByTag(string tag)
        {
            Console.WriteLine($"Exploring stories by tag: \"{tag}\"");
            // Placeholder for enabling users to discover stories using tags
        }
    }
}
