namespace EternalQuestProgram
{
    // Represents a simple goal that can be marked complete
    class SimpleGoal : Goal
    {
        new private bool _isComplete; // Indicates whether the goal is complete or not

        // Constructor
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false; // Initialize as incomplete
        }

        // Method to mark the goal as complete
        public void MarkComplete()
        {
            _isComplete = true;
        }

        // Method to record an event for the simple goal
        public override void RecordEvent()
        {
            MarkComplete(); // Mark the goal as complete when recording an event
            base.RecordEvent(); // Call the base class's RecordEvent method
        }

        // Method to get the details string for the simple goal
        public override string GetDetailsString()
        {
            return $"{ShortName}: {_description} - {(_isComplete ? "Completed" : "Not completed")}";
        }
    }
}
