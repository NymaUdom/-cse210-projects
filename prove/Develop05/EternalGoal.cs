namespace EternalQuestProgram
{
    // Represents an eternal goal that is never complete but gives points each time it is recorded
    class EternalGoal : Goal
    {
        // Constructor
        public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
        {
            // No additional initialization needed
        }

        // Overrides the base class method to record an event for the eternal goal
        public override void RecordEvent()
        {
            // Do nothing as the eternal goal is never complete
        }

        // Overrides the base class method to check if the goal is complete
        public override bool IsComplete()
        {
            return false; // Eternal goal is never complete
        }

        // Overrides the base class method to get the details string for the eternal goal
        public override string GetDetailsString()
        {
            return $"{_shortName}: {_description} - Ongoing";
        }
    }
}
