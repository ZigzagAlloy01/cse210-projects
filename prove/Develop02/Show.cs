public class Show
{
    public List<string> _journal;
    public void Display()
    {
        for (int i = 0; i < _journal.Count; i++)
            {
                string show = _journal[i];
                Console.WriteLine(show);
            }
    }
}