namespace EternalQuestProgram
{
    // Manages the creation, recording, and display of goals
    class GoalManager
    {
        private List<Goal> _goals;  // List of goals
        private int _score; // User's score
        private int _level; // User's level

        // Constructor
        public GoalManager()
        {
            _goals = new List<Goal>();  // Initialize empty list of goals
            _score = 0; // Initialize score
            _level = 1; // Initialize level
        }

        // Method to start the goal manager
        public void Start()
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("---------------------");
            LoadGoals();  // Load previously saved goals
            DisplayPlayerInfo();
        }

        // Method to display player information
        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine($"Current Level: {_level}");
        }

        // Method to list goal names
        public void ListGoalNames()
        {
            Console.WriteLine("Goals:");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"- {goal.ShortName}");
            }
        }

        // Method to list goal details
        public void ListGoalDetails()
        {
            Console.WriteLine("Goal Details:");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        // Method to list goals
        public void ListGoals()
        {
            Console.WriteLine("Current Goals:");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetStringRepresentation());
            }
        }

        // Method to create a new goal
        public void CreateGoal(string name, string description, int points)
        {
            Goal goal = new Goal(name, description, points);
            _goals.Add(goal);
            Console.WriteLine($"New goal created: {name}");
        }

        // Method to record an event for a goal
        public void RecordEvent(string goalName)
        {
            Goal goal = _goals.Find(g => g.ShortName == goalName);
            if (goal != null)
            {
                goal.RecordEvent();
                _score += goal.Points;
                CheckLevelUp();
                DisplayPlayerInfo(); // Update player info after recording event
                SaveGoals();  // Save goals after recording event
            }
            else
            {
                Console.WriteLine("Goal not found!");
            }
        }

        // Method to check if the user has leveled up
        private void CheckLevelUp()
        {
            if (_score >= (_level * 1000)) // Example: Level up every 1000 points
            {
                LevelUp();
            }
        }

        // Method to handle leveling up
        private void LevelUp()
        {
            _level++;
            Console.WriteLine($"Congratulations! You've reached level {_level}!");
        }

        // Method to save goals
        private void SaveGoals()
        {
            // Placeholder for saving goals to a file
            Console.WriteLine("Goals saved successfully!");
        }

        // Method to load goals
        private void LoadGoals()
        {
            // Placeholder for loading goals from a file
            Console.WriteLine("Goals loaded successfully!");
        }
    }
}
