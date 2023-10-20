public class Reference 
{
    public List<int> _referencesIndexes;
    public List<string> _listOfReferences;

    public string WriteReference() {
        int hereIndex = _referencesIndexes[0];
        string exactReference = _listOfReferences[hereIndex];
        return exactReference;
    }


}
