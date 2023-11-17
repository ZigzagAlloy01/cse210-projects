public class SimpleGoal : Nowhere {
    private string _name;
    private List<string> _simpleGoals = new List<string> {};
    private string _description;
    private List<int> _scoreSimple = new List<int> {};
    public SimpleGoal() {
        Console.WriteLine(" ");
    }
    public SimpleGoal(string name, string description) {
        
        _name = name;
        _description = description;
        _simpleGoals.Add($"{_name}: {_description}");
    }
    public override int DisplayMenu()
    {
        _currentPoints.Add(0);
        Console.WriteLine($"You have {_currentPoints[-1]} points.");
        Console.WriteLine(" ");
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        string userInput = Console.ReadLine();
        _userNumber = int.Parse(userInput);
        return _userNumber;
    }
    public int WriteGoal() {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?");
        _goalNumber = Console.ReadLine();
        _goalInt = int.Parse(_goalNumber);
        return _goalInt;
    }
    public override string WriteTitle(){
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.WriteLine(" ");
        return _title;
    }
    public override string WriteDescription() {
        Console.Write("What is a short description of it? ");
        _details = Console.ReadLine();
        Console.WriteLine(" ");
        Console.Write("What is the amount of points associated with this goal? ");
        _pointAssociated = Console.ReadLine();
        _points = int.Parse(_pointAssociated);
        Console.WriteLine(" ");
        return _details;
    }
    public override void recordEvent() {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _titles.Count; i++)
            {
                string show = _titles[i];
                Console.WriteLine($"{i+1}. {show}");
            }
        Console.WriteLine("Which goal did you accomplish? ");
        _pointAssociated = Console.ReadLine();
        _points = int.Parse(_pointAssociated);
        _scoreSimple.Add(_points);
    }

    public bool isComplete() {
        _completed = true;
        return _completed;
    }
}