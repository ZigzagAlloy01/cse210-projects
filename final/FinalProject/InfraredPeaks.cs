public class InfraredPeaks : Molecules {
    private List<string> _wavenumber = new List<string> {"Broad peak around 3300 cm⁻¹ (O-H stretching)", "Broad peak around 3300 cm⁻¹ (O-H stretching)", "Broad peak around 3300 cm⁻¹ (O-H stretching)", "Broad peak around 3300 cm⁻¹ (O-H stretching)", "Broad peak around 3300 cm⁻¹ (O-H stretching)", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=C stretching around 1600 cm⁻¹", "C=C stretching around 1600 cm⁻¹", "C=C stretching around 1600 cm⁻¹", "C=C stretching around 1600 cm⁻¹", "C=C stretching around 1600 cm⁻¹", "C=O stretching around 1700 cm⁻¹, O-H stretching around 3000-3300 cm⁻¹", "C=O stretching around 1700 cm⁻¹, O-H stretching around 3000-3300 cm⁻¹", "C=O stretching around 1700 cm⁻¹, O-H stretching around 3000-3300 cm⁻¹", "C=O stretching around 1700 cm⁻¹, O-H stretching around 3000-3300 cm⁻¹", "C=O stretching around 1700 cm⁻¹, O-H stretching around 3000-3300 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "N-H stretching around 3300 cm⁻¹, C-N stretching around 1200 cm⁻¹", "N-H stretching around 3300 cm⁻¹, C-N stretching around 1200 cm⁻¹", "N-H stretching around 3300 cm⁻¹, C-N stretching around 1200 cm⁻¹", "N-H stretching around 3300 cm⁻¹, C-N stretching around 1200 cm⁻¹", "N-H stretching around 3300 cm⁻¹, C-N stretching around 1200 cm⁻¹"};
    public InfraredPeaks() {
        
    }
    public override string GetFeatureInformation(int index)
    {
        return _wavenumber[index];
    }
    public override string GetName(int index) {
        return $"Name of the Molecule: {_moleculesName[index]} ({_moleculesFormula[index]})";
    }
}