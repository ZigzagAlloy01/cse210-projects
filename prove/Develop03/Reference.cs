public class Reference 
{
    public List<int> _referenceIndexes;
    private int _hereIndex;
    private List<string> _listOfReferences = new List<string> {"1 Nephi 19:11", "2 Nephi 31:3", "Jacob 4:6", "Enos 1:5", "Omni 1:26", "Mosiah 3:11", "Alma 5:27"};
    public string WriteReference() {
        _hereIndex = _referenceIndexes[0];
        string exactReference = _listOfReferences[_hereIndex];
        return exactReference;
    }
}
