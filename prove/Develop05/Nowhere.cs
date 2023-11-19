using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public abstract class Nowhere {
    public int _userNumber;
    public string _goalNumber;
    public int _goalInt;
    public string _detail;
    public string _txt;
    public string _title;
    public string _pointAssociated;
    public int _points;
    public bool _completed;
    public string _X;
    public List<string> _simpleGoalsDetail = new List<string> {};
    public List<string> _eternalGoalsDetail = new List<string> {};
    public List<string> _checkGoalsDetail = new List<string> {};
    public List<string> _goals = new List<string> {};
    public List<string> _loadFileData = new List<string> {};
    public List<string> _titles = new List<string> {};
    public List<string> _marksSimple = new List<string> {};
    public List<string> _marksEternal = new List<string> {};
    public List<string> _marksChecklist = new List<string> {};
    public List<int> _count = new List<int> {};
    public List<int> _limit = new List<int> {};
    public List<int> _loadFilePoints = new List<int> {};
    public abstract void recordEvent(int points);
    public int DisplayMenu() {
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
    public List<int> GiveMyCount() {
        return _count;
    }
    public List<int> GiveMyLimit() {
        return _limit;
    }
    public void FirstIndex() {
        _marksSimple.Add(" ");
        _marksEternal.Add(" ");
        _marksChecklist.Add(" ");
        _simpleGoalsDetail.Add("None");
        _eternalGoalsDetail.Add("None");
        _checkGoalsDetail.Add("None");
        _count.Add(1);
        _limit.Add(1);
        _count.Add(0);
        _limit.Add(0);
    }
    public int WriteGoal() {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        _goalNumber = Console.ReadLine();
        _goalInt = int.Parse(_goalNumber);
        return _goalInt;
    }    
    public abstract string WriteTitle();
    public abstract string WriteDescription();

    public void ListGoalsSimple() {
        Console.WriteLine("The goals are: ");
        Console.WriteLine("Simple Goals");
        for (int i = 0; i < _simpleGoalsDetail.Count; i++)
            {
                _X = _marksSimple[i];
                string show = _simpleGoalsDetail[i];
                Console.WriteLine($"{i+1}. [{_X}] {show}");
            }
    }
    public void ListGoalsEternal() {
        Console.WriteLine("Eternal Goals");
        
        for (int i = 0; i < _eternalGoalsDetail.Count; i++)
            {
                _X = _marksEternal[i];
                string show = _eternalGoalsDetail[i];
                Console.WriteLine($"{i+1}. [{_X}] {show}");
            }
    }
    public void ListGoalsChecklist() {
        Console.WriteLine("Check List Goals");
        for (int i = 0; i < _checkGoalsDetail.Count; i++)
            {
                _X = _marksChecklist[i];
                string show = _checkGoalsDetail[i];
                int current = _count[i+1];
                int final = _limit[i+1];
                Console.WriteLine($"{i+1}. [{_X}] {show} -- Currently completed: {current}/{final}");
            }
    }    
    public void LoadGoals()
    {
        Console.Write("What is the file name? "); 
        string answer = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(answer);
        _goals.Clear();
        foreach (string line in lines)
            {
                string[] parts = line.Split(" - ");
                string data = parts[0];
                _goals.Add(data);
                data = parts[1];
                _goals.Add(data);
            }
        foreach(string line in lines)
            {
                string[] parts = line.Split(" / ");
                string data = parts[0];
                _loadFileData.Add(data);
                Console.WriteLine(data);
                data = parts[1];
                _loadFileData.Add(data);
                Console.WriteLine(data);
                data = parts[2];
                _loadFileData.Add(data);
                Console.WriteLine(data);
                data = parts[3];
                _loadFileData.Add(data);
                Console.WriteLine(data);
                data = parts[4];
                _loadFileData.Add(data);
                Console.WriteLine(data);
            }
            Console.WriteLine("Load file");
        foreach (string i in _loadFileData) {
            Console.WriteLine(i);
        }
    }
    public void bringBackData() {
        int lenght = _loadFileData.Count;
        Console.WriteLine(lenght);
        int start = _loadFileData.IndexOf(" - Check List Goals");
        Console.WriteLine(start);
        Console.WriteLine(" ");
        int z = -1;
        for (int i = start + 6; i < lenght; i++) {
            int j = start + 6;
            if ((i == j + 4) || (i == j + 4 + 5) || (i == j + 4 + (5 * (z+1)))){
                z++;
            }
            if ((i != j + 4) && (i != j + 4 + 5) && (i != j + 4 + (5 * z))){
                string score = _loadFileData[i];
                int importantValue = int.Parse(score);
                Console.WriteLine(importantValue);
                _loadFilePoints.Add(importantValue);
            }
            
        }
        for (int i = 0; i < _loadFilePoints.Count; i++) {
                Console.WriteLine(_loadFilePoints[i]);
        }
    }
    public void bringBackList() {
        int start = _loadFileData.IndexOf(" - Check List Goals");
        for (int i = 0; i < start+1; i = i + 5){
            Console.WriteLine($"{_loadFileData[i]}");
        }
        for (int i = start+1; i < _loadFileData.Count; i = i + 5){
            int j = 0;
            Console.WriteLine($"{_loadFileData[i]} {_loadFilePoints[j]} / {_loadFilePoints[j+1]}");
            //_simpleGoalsDetail 
            //_eternalGoalsDetail
            //_checkGoalsDetail
            j = j + 4;
        }
            
    }
}