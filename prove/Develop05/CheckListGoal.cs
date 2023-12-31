public class CheckListGoal : Nowhere {
    private string _name;
    private string _description;
    private List<int> _associatedPoints = new List<int> {};
    private List<int> _bonusPoints = new List<int> {};
    public CheckListGoal() {
        Console.WriteLine(" ");
    }
    public void ListOfCheckedGoals(string name, string description) {
        _name = name;
        _description = description;
        _checkGoalsDetail.Add($"{_name}: {_description}");
        _marksChecklist.Add(" ");
    }
    public List<int> GivePoints() {
        return _associatedPoints;
    }
    public List<int> GiveBonusPoints() {
        return _bonusPoints;
    }
    public override string WriteTitle(){
        _checkGoalsDetail.Remove("None");
        Console.Write("What is the name of your goal? ");
        _title = Console.ReadLine();
        Console.WriteLine(" ");
        _titles.Add(_title);
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
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _pointAssociated = Console.ReadLine();
        _points = int.Parse(_pointAssociated);
        _count.Add(0);
        _limit.Add(_points);
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _pointAssociated = Console.ReadLine();
        _points = int.Parse(_pointAssociated);
        _bonusPoints.Add(_points);
        return _detail;
    }
    public void FillList() {
        _associatedPoints.Add(0);
        _bonusPoints.Add(0);
    }
    public void SaveGoalsChecklist(string _txt, List<string> _goals)
    {
        using (StreamWriter sw = File.AppendText($"{_txt}"))
        {
            _goals.Add(" - Check List Goals / * / * / * / ");
            if (_associatedPoints.Count > 1) {
                _associatedPoints.Remove(0);
                _bonusPoints.Remove(0);
            }
            for (int i = 0; i < _checkGoalsDetail.Count; i++)
                {
                    _X = _marksChecklist[i];
                    string show = _checkGoalsDetail[i];
                    int current = _count[i+1];
                    int final = _limit[i+1];
                    int associatedScore = _associatedPoints[i];
                    int bonusScore = _bonusPoints[i];
                    _goals.Add($" - {i+1}. [{_X}] {show} -- Currently completed: / {current} / {final} / {associatedScore} / {bonusScore}");
                }
            for (int i = 0; i < _goals.Count; i++)
            {
                string entry = _goals[i];
                sw.WriteLine(entry);
            }
        }
            
    }
    public override void recordEvent(int points) {
        _points = points;
    }
}