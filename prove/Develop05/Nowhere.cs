public abstract class Nowhere {
    public int _userNumber;
    public string _goalNumber;
    public int _goalInt;
    public string _details;
    public string _title;
    public string _pointAssociated;
    public int _points;
    public bool _completed;
    public string _X;
    public List<string> _simpleGoals = new List<string> {};
    public List<string> _eternalGoals = new List<string> {};
    public List<string> _checkGoals = new List<string> {};
    public List<string> _goals = new List<string> {};
    public List<string> _titles = new List<string> {};
    public List<int> _currentPoints = new List<int> {};
    public abstract void recordEvent();
    public abstract int DisplayMenu();
    public abstract string WriteTitle();
    public abstract string WriteDescription();

    public void ListGoals() {
        Console.WriteLine("The goals are: ");
        Console.WriteLine("Simple Goals");
        for (int i = 0; i < _simpleGoals.Count; i++)
            {
                string show = _simpleGoals[i];
                Console.WriteLine($"{i+1}. {show}");
            }
        Console.WriteLine("Eternal Goals");
        for (int i = 0; i < _eternalGoals.Count; i++)
            {
                string show = _eternalGoals[i];
                Console.WriteLine($"{i+1}. {show}");
            }
        Console.WriteLine("Check List Goals");
        for (int i = 0; i < _checkGoals.Count; i++)
            {
                string show = _checkGoals[i];
                Console.WriteLine($"{i+1}. {show}");
            }
        Console.WriteLine("You have X points");
    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the file name? "); 
            string answer = Console.ReadLine();
            using (StreamWriter sw = File.CreateText(answer))
            {
                for (int i = 0; i < _goals.Count; i++)
                {
                    string entry = _goals[i];
                    sw.WriteLine(entry);
                }
            }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the file name? "); 
        string answer = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(answer);
        _goals.Clear();
        foreach (string line in lines)
            {
                string[] parts = line.Split(" - ");
                string dateFile = parts[0];
                string first = parts[1];
                string last = parts[2];
                Console.WriteLine($"{dateFile} - {first}");
                Console.WriteLine($" - {last}");
                string entry = $"[{_X}] {_title} ({_details})";
                _goals.Add(entry);
            }
    }

}