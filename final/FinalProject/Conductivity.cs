public class Conductivity : Molecules {
    private List<string> _electrical = new List<string> {"Low electrical conductivity"};

    public Conductivity() {
        
    }
    public override string GetFeatureInformation(int index)
    {
        int i = index * 0;
        return $"pKa: {_electrical[i]}";
    }
    public override string GetName(int index) {
        return $"Name of the Molecule: {_moleculesName[index]} ({_moleculesFormula[index]})";
    }
}