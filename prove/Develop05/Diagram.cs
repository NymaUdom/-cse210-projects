/*
GoalManager                          Goal   

_goals : List<Goal>                 _shortName : string
_score : int                        _description : string
                                    _points : string

GoalManager()                       Goal(name, description, points)
Start() : void                      RecordEvent() : void
DisplayPlayerInfo() : void          IsComplete() : bool
ListGoalNames() : void              GetDetailsString() : string
ListGoalDetails() : void            GetStringRepresentation() : string
ListGoals() : void                                  |
CreateGoal() : void                                 |
RecordEvent() : void                                |
SaveGoals() : void                                  |
LoadGoals() : void                                  |
                                                    |
        SimpleGoal                                   EternalGoal                                    ChecklistGoal
    
    _IsComplete : bool                                                                                  _amountComplete  : int
                                                                                                        _target : int
                                                                                                        _bonus : int

    SimpleGoal(name, desscription, points)          EternalGoal(name, description, points)              ChecklistGoal(name, description, points, target, bonus)
                                                                                                        

    RecordEvent() : void                            RecordEvent() : void                                RecordEvent() : void
    IsComplete() : bool                             IsComplete() : bool                                 IsComplete() : bool
    GetStringRepresentation() : string              GetStringRepresentation() : string                  GetDatialsString() : string
                                                                                                        GetStringRepresentation() : string






*/