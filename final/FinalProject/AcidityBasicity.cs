public class AcidityBasicity : Molecules {
    private List<string> _pKa = new List<string> {"~15.5", "~15.9", "~16.1", "~16.2", "~16.4", "Ketones are not acidic under normal conditions", "Ketones are not acidic under normal conditions", "Ketones are not acidic under normal conditions", "Ketones are not acidic under normal conditions", "Ketones are not acidic under normal conditions", "Aromatic hydrocarbons are not acidic under normal conditions", "Aromatic hydrocarbons are not acidic under normal conditions", "Aromatic hydrocarbons are not acidic under normal conditions", "Aromatic hydrocarbons are not acidic under normal conditions", "Aromatic hydrocarbons are not acidic under normal conditions", "~3.75", "~4.76", "~4.87", "~4.83", "~4.82", "Formaldehyde is not acidic under normal conditions", "~16-17", "~16-17", "~16-17", "~16-17", "~4.6", "~4.4", "~10.7", "~9.8", "~11.2"};

    public AcidityBasicity() {
        
    }
    public override string GetFeatureInformation(int index)
    {
        return $"pKa: {_pKa[index]}";
    }
    public override string GetName(int index) {
        return $"Name of the Molecule: {_moleculesName[index]} ({_moleculesFormula[index]})";
    }
}