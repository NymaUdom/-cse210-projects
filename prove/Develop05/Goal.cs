namespace EternalQuestProgram
{
    // Base class representing a goal
    class Goal
    {
        // Properties
        protected string _shortName;
        protected string _description;
        protected int _points;
        protected bool _isComplete; // New property to track completion status

        // Constructor
        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
            _isComplete = false; // Initialize as incomplete
        }

        // Method to record an event for the goal
        public virtual void RecordEvent()
        {
            // Base logic for recording event
            Console.WriteLine($"Event recorded for {_shortName}. Points earned: {_points}");
            _isComplete = true; // Mark the goal as complete
        }

        // Method to check if the goal is complete
        public virtual bool IsComplete()
        {
            return _isComplete;
        }

        // Method to get a string representation of the goal's details
        public virtual string GetDetailsString()
        {
            return $"{_shortName}: {_description}";
        }

        // Method to get a string representation of the goal
        public virtual string GetStringRepresentation()
        {
            return $"{_shortName} - Points: {_points}";
        }

        // Properties
        public string ShortName { get { return _shortName; } }
        public int Points { get { return _points; } }
    }
}
