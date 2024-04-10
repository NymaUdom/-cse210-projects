namespace StoryHub
{
    public class User : BaseEntity
    {
        // Additional properties specific to User class
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

        // Additional methods specific to User class
        // User registration method
        public void Register(string username, string password, string email)
        {
            // Check if username is already taken
            // Check if email is already registered

            // If username and email are available, create a new user
            Username = username;
            Password = password;
            Email = email;

            Console.WriteLine("Registration successful!");
        }

        // User login method
        public bool Login(string username, string password)
        {
            // Check if username and password match stored credentials
            if (Username == username && Password == password)
            {
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
                return false;
            }
        }

        // Method to submit a story
        public void SubmitStory(Story story)
        {
            // Placeholder for submitting a story
            SubmittedStories.Add(story);
        }

        // Method to approve a story
        public void ApproveStory(Story story)
        {
            // Placeholder for approving a story
            ApprovedStories.Add(story);
        }
    }
}
