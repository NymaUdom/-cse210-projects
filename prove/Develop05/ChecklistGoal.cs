namespace EternalQuestProgram
{
    // Represents a checklist goal that must be accomplished a certain number of times to be complete
    class ChecklistGoal : Goal
    {
        private int _amountComplete; // Amount of times the goal has been completed
        private int _target; // Target number of completions needed
        private int _bonus; // Bonus points upon completion

        // Constructor
        public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
        {
            _amountComplete = 0;
            _target = target;
            _bonus = bonus;
        }

        // Overrides the base class method to record an event for the checklist goal
        public override void RecordEvent()
        {
            _amountComplete++;
            if (_amountComplete >= _target)
            {
                _points += _bonus; // Add bonus points upon completion
            }
        }

        // Overrides the base class method to check if the goal is complete
        public override bool IsComplete()
        {
            return _amountComplete >= _target;
        }

        // Overrides the base class method to get the details string for the checklist goal
        public override string GetDetailsString()
        {
            return $"{_shortName}: {_description} - Completed {_amountComplete}/{_target} times";
        }
    }
}
