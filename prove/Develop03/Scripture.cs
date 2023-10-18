using System.ComponentModel.DataAnnotations;

public class Scripture 
{
    public string _file;
    public List<string> _listOfScriptures;
    public List<string> _election;
    private List<string> _lettersInScripture = new List<string>();
    public Scripture() {}
    public void LoadScripture()  {
        Random rnd = new Random();
        string anyScripture = _listOfScriptures[rnd.Next(6)];
        Console.WriteLine(anyScripture);
        _election.Add(anyScripture);
        }
    public void GetScripture() {
        string elements = _election[0];
        char [] letters = elements.ToCharArray();
        foreach (char letter in letters) {
            _lettersInScripture.Add((letter.ToString()));
        }
    }
    public string GetBlackedOutScripture() {
        Random rnd = new Random();
        string anyLetter = _lettersInScripture[rnd.Next(_lettersInScripture.Count)];
        return anyLetter;
    }

}