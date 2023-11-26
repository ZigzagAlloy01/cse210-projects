public class SimpleGoal : Nowhere {
    private string _name;
    private string _description;
    private List<int> _associatedPoints = new List<int> {};
    public SimpleGoal() {
        Console.WriteLine(" ");
    }
    public void ListOfSimpleGoals(string name, string description) {
        _name = name;
        _description = description;
        _simpleGoalsDetail.Remove("None");
        _simpleGoalsDetail.Add($"{_name}: {_description}");
        _marksSimple.Add(" ");
    }
    public List<int> GivePoints() {
        return _associatedPoints;
    }
    public override string WriteTitle(){
        _simpleGoalsDetail.Remove("None");
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.WriteLine(" ");
        return _title;
    }
    public override string WriteDescription() {
        Console.Write("What is a short description of it? ");
        _detail = Console.ReadLine();
        Console.WriteLine(" ");
        Console.Write("What is the amount of points associated with this goal? ");
        _pointAssociated = Console.ReadLine();
        _points = int.Parse(_pointAssociated);
        _associatedPoints.Add(_points);
        Console.WriteLine(" ");
        return _detail;
    }
    public void FillList() {
        _associatedPoints.Add(0);
    }
    public string SaveGoalsSimple() {
        Console.Write("What is the file name? "); 
        _txt = Console.ReadLine();
        using (StreamWriter sw = File.CreateText($"{_txt}"))
        {
            if (_associatedPoints.Count > 1) {
                _associatedPoints.Remove(0);
            }
            _goals.Clear();
            _goals.Add(" - / * / * / * / The goals are: ");
            _goals.Add(" - Simple Goals / * / * / * / ");
            for (int i = 0; i < _simpleGoalsDetail.Count; i++)
                {
                    _X = _marksSimple[i];
                    string show = _simpleGoalsDetail[i];
                    int associatedScore = _associatedPoints[i];
                    _goals.Add($" - {i+1}. [{_X}] {show} / {associatedScore} / * / * / *");
                }
        }
        return _txt;
        }    

    public List<string> DeliverGoals() {
        return _goals;
    }
    public override void recordEvent(int points) {
        _points = points;
    }

    public bool isComplete() {
        _completed = true;
        return _completed;
    }
}