public class SimpleGoal : CheckListGoal {
    private string _name;
    private List<string> _simpleGoals = new List<string> {};
    private string _description;
    private int _points;
    private List<int> _scoreSimple = new List<int> {};
    private bool _completed;
    public SimpleGoal(string name, string description) {
        _name = name;
        _description = description;
        _simpleGoals.Add($"{_name}: {_description}");
    }
    public override void recordEvent() {
        _points = 100;
        _scoreSimple.Add(_points);
    }

    public bool isComplete() {
        _completed = true;
        return _completed;
    }
}