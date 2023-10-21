public class Reference 
{
    public List<int> _referenceIndexes;
    public List<string> _listOfReferences;
    public string WriteReference() {
        int hereIndex = _referenceIndexes[0];
        string exactReference = _listOfReferences[hereIndex];
        return exactReference;
    }
}
