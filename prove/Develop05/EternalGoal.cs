public class EternalGoal : CheckListGoal {
    private string _name;
    private string _description;
    private List<string> _eternalGoals = new List<string> {};
    private bool _completed;
    private int _points;
    private List<int> _scoreEternal = new List<int> {};
    public EternalGoal(string name, string description) {
        _name = name;
        _description = description;
        _eternalGoals.Add($"{_name}: {_description}");
    }
    public override void recordEvent() {
        _points = 200;
        _scoreEternal.Add(_points);
    }
    public bool isComplete() {
        _completed = false;
        return _completed;
    }
}