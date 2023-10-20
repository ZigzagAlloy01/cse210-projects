public class Word 
{
    public List<int> _wordIndexList;
    public List<string> _election;
    public List<string> _lettersInScripture;
    private int _wordIndex;

    public void ShowLetters() {
        int i = 0;
        while (i < _lettersInScripture.Count)
        {
            Console.WriteLine(_lettersInScripture[i]);
            i++;
        }
        _wordIndex = _wordIndexList[0];
        Console.WriteLine(_lettersInScripture[_wordIndex]);
    }
}