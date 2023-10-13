public class Journal
{
    public List<string> _journal;
    public Journal() {}
    public void ShowJournal()
    {
        for (int i = 0; i < _journal.Count; i++)
            {
                string show = _journal[i];
                Console.WriteLine(show);
            }
    }
    public void SaveJournal()
    {
        Console.WriteLine("What is the file name? "); 
            string answer = Console.ReadLine();
            using (StreamWriter sw = File.CreateText(answer))
            {
                for (int i = 0; i < _journal.Count; i++)
                {
                    string entry = _journal[i];
                    sw.WriteLine(entry);
                }
            }
    }
    public void LoadJournal()
    {
        Console.WriteLine("What is the file name? "); 
        string answer = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(answer);
        _journal.Clear();
        foreach (string line in lines)
            {
                string[] parts = line.Split(" - ");
                string dateFile = parts[0];
                string first = parts[1];
                string last = parts[2];
                Console.WriteLine($"{dateFile} - {first}");
                Console.WriteLine($" - {last}");
                string entry = $"{dateFile} - {first} - {last}";
                _journal.Add(entry);
            }
    }
    public void DeleteJournal()
    {
        Console.WriteLine("What is the file name of the file you want to delete? "); 
        string answer = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(answer);
        _journal.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split(" - ");
            string dateFile = parts[0];
            string first = parts[1];
            string last = parts[2];
            string entry = $"{dateFile} - {first} - {last}";
            _journal.Add(entry);
        }
        using (StreamWriter sw = File.CreateText(answer))
        {
            for (int i = 0; i < _journal.Count; i++)
            {
                sw.WriteLine(" ");
            }
        }
        Console.WriteLine($"All the text in {answer} has been deleted.");
    }
}