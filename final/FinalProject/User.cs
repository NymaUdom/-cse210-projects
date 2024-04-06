namespace StoryHub
{
    public class User
    {
        // Properties
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Story> SubmittedStories { get; set; }
        public List<Story> ApprovedStories { get; set; }

        // Constructor
        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
            SubmittedStories = new List<Story>();
            ApprovedStories = new List<Story>();
        }

        // Methods
        public void SubmitStory(Story story)
        {
            // Placeholder for submitting a story
            SubmittedStories.Add(story);
        }

        public void ApproveStory(Story story)
        {
            // Placeholder for approving a story
            ApprovedStories.Add(story);
        }
    }
}
