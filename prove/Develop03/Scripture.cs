using System.ComponentModel.DataAnnotations;

public class Scripture 
{
    public string _file;
    private int _referenceIndex;
    public List<int> _referencesIndexes;
    private int _wordIndex;
    public List<int> _wordIndexList;
    public List<string> _listOfScriptures;
    public List<string> _election;
    public List<string> _lettersInScripture;
    public Scripture() {}
    public string WriteScripture()  {
        Random rnd = new Random();
        string anyScripture = _listOfScriptures[rnd.Next(6)];
        _election.Add(anyScripture);
        _referenceIndex = _listOfScriptures.IndexOf(anyScripture);
        _referencesIndexes.Add(_referenceIndex);
        return anyScripture;
        }
    public void GetScriptureLetters() {
        string elements = _election[0];
        char [] letters = elements.ToCharArray();
        foreach (char letter in letters) {
            string requiredLetter = letter.ToString();
            _lettersInScripture.Add(requiredLetter);
        }
    }
    public void GetBlackedOutScripture() {
        Random rnd = new Random();
        _wordIndex = rnd.Next(_lettersInScripture.Count);
        _wordIndexList.Add(_wordIndex);
    }
}