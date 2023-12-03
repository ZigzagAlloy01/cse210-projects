public class Solubility : Molecules {
    private List<string> _solubility = new List<string> {"Miscible in water", "Miscible in water", "Miscible in water", "~8.3 g/mL in water", "Insoluble or slightly soluble in water", "Miscible in water", "Miscible in water", "Miscible in water", "Miscible in water", "Miscible in water", "Insoluble in water", "Insoluble in water", "Insoluble in water", "Insoluble in water", "Insoluble in water", "Soluble in water", "Soluble in water", "Soluble in water", "Soluble in water", "Soluble in water", "Miscible in water", "Miscible in water", "Miscible in water", "Miscible in water", "Miscible in water", "~3 g/mL in water", "~4.7 g/mL in water", "Miscible in water", "Miscible in water", "Miscible in water"};
    public Solubility() {
        
    }
    public override string GetFeatureInformation(int index)
    {
        return _solubility[index];
    }
    public override string GetName(int index) {
        return $"Name of the Molecule: {_moleculesName[index]} ({_moleculesFormula[index]})";
    }
}