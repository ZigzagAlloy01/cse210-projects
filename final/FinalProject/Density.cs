public class Density : Molecules {
    private List<string> _moleculesDensity = new List<string> {"0.79 g/cm³", "0.789 g/cm³", "0.804 g/cm³", "0.81 g/cm³", "0.814 g/cm³", "0.784 g/cm³", "0.805 g/cm³", "0.805 g/cm³", "< 0.85 g/cm³", "< 0.85 g/cm³", "0.876 g/cm³", "0.866 g/cm³", "0.87 g/cm³", "1.15 g/cm³", "1.283 g/cm³", "1.22 g/cm³", "1.049 g/cm³", "0.992 g/cm³", "0.96 g/cm³", "< 1.3 g/cm³", "0.815 g/cm³", "0.789 g/cm³", "> 0.79 g/cm³", "> 0.79 g/cm³", "> 0.79 g/cm³", "1.022 g/cm³", "> 0.65 g/cm³", "0.707 g/cm³", "0.64 g/cm³", "0.862 g/cm³"};
    public Density() {
        
    }
    public override string GetFeatureInformation(int index)
    {
        return $"Density: {_moleculesDensity[index]}";
    }
    public override string GetName(int index) {
        return $"Name of the Molecule: {_moleculesName[index]} ({_moleculesFormula[index]})";
    }
}