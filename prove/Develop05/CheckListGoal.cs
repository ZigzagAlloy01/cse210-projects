public class CheckListGoal : Nowhere {
    private string _name;
    private string _description;
    private List<string> _checkListGoals = new List<string> {};
    private List<int> _scoreCheck = new List<int> {};
    public CheckListGoal() {
        Console.WriteLine(" ");
    }
    public override int DisplayMenu()
    {
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
    public void ListOfCheckedGoals(string name, string description) {
        _name = name;
        _description = description;
        _checkGoals.Add($"{_name}: {_description}");
    }
    public override void recordEvent() {
        _points = 200;
        _scoreCheck.Add(_points);
    }
    public bool isComplete() {
        _completed = false;
        return _completed;
    }
}