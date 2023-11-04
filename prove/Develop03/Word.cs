public class Word 
{
    public List<string> _lettersInScripture;
    private int _wordIndex;
    private int _countDifferences;
    private string _result;
    private bool _evaluation;
    public string EraseLetters() {
        Random rnd = new Random();
        _wordIndex = rnd.Next(_lettersInScripture.Count);
        _lettersInScripture[_wordIndex] = " ___ ";
        _result = string.Join(" ", _lettersInScripture);
        return _result;
    }
    public bool EndGame() {
        var j = _lettersInScripture.Count;
        _countDifferences = 0;
        for (int i = 0; i < j; i++)
        {
            if(_lettersInScripture[i] == " ___ ")
            {
                _countDifferences++;
            }
        }
        if (_countDifferences == j){
            _evaluation = false;
        }
        else if (_countDifferences != j){
            _evaluation = true;
        }
        return _evaluation;
    }
}