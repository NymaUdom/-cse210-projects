namespace StoryHub
{
    public class Story : BaseEntity
    {
        // Additional properties specific to Story class
        public User Author { get; set; }

        // Constructor
        public Story(string title, string content, User author)
        {
            Title = title;
            Content = content;
            Author = author;
            Verified = false;
            Evidence = "";
        }

        // Additional methods specific to Story class
    }
}
