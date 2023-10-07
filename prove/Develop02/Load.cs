public class Load
{
    public List<string> _journal;
    public void Display()
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
}