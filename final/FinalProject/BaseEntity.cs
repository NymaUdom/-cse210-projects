namespace StoryHub
{
    public class BaseEntity
    {
        // Common properties shared among User and Story classes
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Verified { get; set; }
        public string Evidence { get; set; }

        // Common methods shared among User and Story classes
        public void Verify()
        {
            // Placeholder for verifying the authenticity of a story
        }

        public void DisplayEvidence()
        {
            // Placeholder for displaying evidence or validation
        }
    }
}
