public class Save
{
    public List<string> _journal;
    public void Display()
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
}