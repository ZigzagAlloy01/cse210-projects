public class EternalGoal : Nowhere {
    private string _name;
    private string _description;

    private List<int> _associatedPoints = new List<int> {};
    public EternalGoal() {
        Console.WriteLine(" ");
    }
    public void ListOfEternalGoals(string name, string description) {
        _name = name;
        _description = description;
        _eternalGoalsDetail.Add($"{_name}: {_description}");
        _marksEternal.Add(" ");
    }
    public override string WriteTitle() {
        _eternalGoalsDetail.Remove("None");
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.WriteLine(" ");
        _titles.Add(_title);
        return _title;
    }

    public void FillList() {
        _associatedPoints.Add(0);
    }
    public void EraseList() {
        _associatedPoints.Remove(0);
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

    public void SaveGoalsEternal(string _txt, List<string> _goals) {
        using (StreamWriter sw = File.AppendText($"{_txt}"))
        {
            _goals.Add(" - Eternal Goals / * / * / * / ");
            for (int i = 0; i < _eternalGoalsDetail.Count; i++)
                {
                    _X = _marksEternal[i];
                    string show = _eternalGoalsDetail[i];
                    int associatedScore = _associatedPoints[i];
                    _goals.Add($" - {i+1}. [{_X}] {show} / {associatedScore} / * / * / * ");
                }
            for (int i = 0; i < _goals.Count; i++)
            {
                string entry = _goals[i];
                sw.WriteLine(entry);
            }
        }
        }    
    public List<string> DeliverGoals() {
        return _goals;
    }
    public override void recordEvent(int points) {
        _points = points;
    }
    public bool isComplete() {
        _completed = false;
        return _completed;
    }
}