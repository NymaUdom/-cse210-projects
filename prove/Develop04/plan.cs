/*
Activity  Opening message, prompt for duration, closing message, pause animation

    -Breathing   Breathing exercise for duration prompted
    -Listing    Listing exercise for duration, random prompt, count listed items
    -Reflection     random prompt, random extension, display prompt, display questions
    
Activity 

    METHODS
        DisplayStartingMessage() : void
        DisplayEndingMessage() : void
        ShowSpinner(seconds : int) : void
        ShowCountDown(seconds : int) : void

    VARIABLES
        _activityName : string
        _duration : int
        _description : string
    
    CONSTRUCTORS
        Activity(activityName : string, duration : int, description : string)
        Activity(duration : int)


Breathing

    METHODS
        Run() : void

    VARIABLES 

    CONSTRUCTORS
        Breathing(duration : int) : base(duration)

Listing

    METHODS
        Run() : void
        GetRandomPrompt() : string
        GetListFromUser() : List<string>
    
    VARIABLES
        _count : int
        _prompts : List<string>
    
    CONSTRUCTORS
        Listing(duration : int) : base(duration)


Reflection

    METHODS
        Run() : void
        GetRandomPrompt() : string
        GetRandomQuestion() : string
        DisplayPrompt() : void
        Display Questions() : void
    
    VARIABLES
        _prompts : List<string>
        _questions : List<string>
    
    CONSTRUCTORS
        Reflection(duration : int) : base(duration)

*/