public class Write
{
    public string _date;
    public List<string> _journal;
    public List<string> _questions;
    public void Display()
    {
        Random rnd = new Random();
        string anyQuestion = _questions[rnd.Next(10)];
        Console.WriteLine(anyQuestion); 
        string answer = Console.ReadLine();
        string entry = $"Date: {_date} - Prompt: {anyQuestion} - {answer}.";
        _journal.Add(entry);
    }
}