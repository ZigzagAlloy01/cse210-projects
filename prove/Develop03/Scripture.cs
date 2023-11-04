using System.ComponentModel.DataAnnotations;

public class Scripture 
{
    private int _referenceIndex;
    private string _anyScripture;
    public List<int> _referenceIndexes = new List<int>();
    private List<string> _listOfScriptures = new List<string> {"The Lord God surely shall visit all the house of Israel at that day, some with his voice, because of their righteousness, unto their great joy and salvation, and others with the thunderings and the lightnings of his power, by tempest, by fire, and by smoke, and vapor of darkness, and by the opening of the earth, and by mountains which shall be carried up.", "For my soul delighteth in plainness; for after this manner doth the Lord God work among the children of men. For the Lord God giveth light unto the understanding; for he speaketh unto men according to their language, unto their understanding.", "Wherefore, we search the prophets, and we have many revelations and the spirit of prophecy; and having all these witnesses we obtain a hope, and our faith becometh unshaken, insomuch that we truly can command in the name of Jesus and the very trees obey us, or the mountains, or the waves of the sea.", "And there came a voice unto me, saying: Enos, thy sins are forgiven thee, and thou shalt be blessed.", "And now, my beloved brethren, I would that ye should come unto Christ, who is the Holy One of Israel, and partake of his salvation, and the power of his redemption. Yea, come unto him, and offer your whole souls as an offering unto him, and continue in fasting and praying, and endure to the end; and as the Lord liveth ye will be saved.", "For behold, and also his blood atoneth for the sins of those who have fallen by the transgression of Adam, who have died not knowing the will of God concerning them, or who have ignorantly sinned.", "Have ye walked, keeping yourselves blameless before God? Could ye say, if ye were called to die at this time, within yourselves, that ye have been sufficiently humble? That your garments have been cleansed and made white through the blood of Christ, who will come to redeem his people from their sins?"};
    private List<string> _election = new List<string>();
    public List<string> _lettersInScripture = new List<string>();
    public string WriteScripture()  {
        Random rnd = new Random();
        _anyScripture = _listOfScriptures[rnd.Next(6)];
        _election.Add(_anyScripture);
        _referenceIndex = _listOfScriptures.IndexOf(_anyScripture);
        _referenceIndexes.Add(_referenceIndex);
        return _anyScripture;
        }
    public void GetScriptureLetters() {
        string elements = _election[0];
        string[] splitter = elements.Split(" ");
        for (int i = 0; i < splitter.Length; i++)
            {
                _lettersInScripture.Add(splitter[i]);
            }
    }
    public void RestoreScripture() {
        _anyScripture = _election[0];
        Console.Write(" ");
        Console.WriteLine(_anyScripture);
        _lettersInScripture.Clear();
    }
}