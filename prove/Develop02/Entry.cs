public class Entry 
{
    public string _date;
    public List<string> _journal;
    public List<string> _questions;
    public int _userNumber;
    public Entry() {}
    public int DisplayMenu()
    {
        Console.WriteLine("Please, select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("6. Delete");
        Console.Write("What would you like to do? "); 
        string userInput = Console.ReadLine();
        _userNumber = int.Parse(userInput);
        return _userNumber;
    }
    public void WriteJournal()
    {
        Random rnd = new Random();
        string anyQuestion = _questions[rnd.Next(10)];
        Console.WriteLine(anyQuestion); 
        string answer = Console.ReadLine();
        string entry = $"Date: {_date} - Prompt: {anyQuestion} - {answer}.";
        _journal.Add(entry);
    }
}