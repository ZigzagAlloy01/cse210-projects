public class Word 
{
    public List<string> _election;
    public List<string> _lettersInScripture;
    public List<string> _voidLetters;
    private int _wordIndex;
    private string _result;
    private bool _evaluation;
    private string _message;

    public string EraseLetters() {
        Random rnd = new Random();
        _wordIndex = rnd.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = "_";
        Random rnd2 = new Random();
        _wordIndex = rnd2.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = "_";
        Random rnd3 = new Random();
        _wordIndex = rnd3.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = "_";
        Random rnd4 = new Random();
        _wordIndex = rnd4.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = "_";
        Random rnd5 = new Random();
        _wordIndex = rnd5.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = "_";
        Random rnd6 = new Random();
        _wordIndex = rnd6.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = "_";
        Random rnd7 = new Random();
        _wordIndex = rnd7.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = "_";
        Random rnd8 = new Random();
        _wordIndex = rnd8.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = "_";
        Random rnd9 = new Random();
        _wordIndex = rnd9.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = "_";
        Random rnd10 = new Random();
        _wordIndex = rnd10.Next(_lettersInScripture.Count);
        Random rnd11 = new Random();
        _wordIndex = rnd11.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = "_";
        _result = string.Join("", _lettersInScripture);
        return _result;
    }
    public bool EndGame() {
        string elements = _result;
        char [] letters = elements.ToCharArray();
        foreach (char letter in letters) {
            string requiredLetter = letter.ToString();
            _voidLetters.Add(requiredLetter);
        }
        _evaluation = true;
        if (_lettersInScripture.Count == _voidLetters.Count)
        {
            for (int i = 0; i < _lettersInScripture.Count; i++)
            {
                if(_lettersInScripture[i] != _voidLetters[i])
                {
                    _evaluation = true;
                }
                else if(_lettersInScripture[i] == _voidLetters[i])
                {
                    _evaluation = false;
                }
            }
        }
        return _evaluation;
    }
}