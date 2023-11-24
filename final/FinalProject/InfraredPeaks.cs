public class InfraredPeaks : Nowhere {
    private List<string> _wavenumber = new List<string> {"Broad peak around 3300 cm⁻¹ (O-H stretching)", "Broad peak around 3300 cm⁻¹ (O-H stretching)", "Broad peak around 3300 cm⁻¹ (O-H stretching)", "Broad peak around 3300 cm⁻¹ (O-H stretching)", "Broad peak around 3300 cm⁻¹ (O-H stretching)", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=C stretching around 1600 cm⁻¹", "C=C stretching around 1600 cm⁻¹", "C=C stretching around 1600 cm⁻¹", "C=C stretching around 1600 cm⁻¹", "C=C stretching around 1600 cm⁻¹", "C=O stretching around 1700 cm⁻¹, O-H stretching around 3000-3300 cm⁻¹", "C=O stretching around 1700 cm⁻¹, O-H stretching around 3000-3300 cm⁻¹", "C=O stretching around 1700 cm⁻¹, O-H stretching around 3000-3300 cm⁻¹", "C=O stretching around 1700 cm⁻¹, O-H stretching around 3000-3300 cm⁻¹", "C=O stretching around 1700 cm⁻¹, O-H stretching around 3000-3300 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "C=O stretching around 1700 cm⁻¹", "N-H stretching around 3300 cm⁻¹, C-N stretching around 1200 cm⁻¹", "N-H stretching around 3300 cm⁻¹, C-N stretching around 1200 cm⁻¹", "N-H stretching around 3300 cm⁻¹, C-N stretching around 1200 cm⁻¹", "N-H stretching around 3300 cm⁻¹, C-N stretching around 1200 cm⁻¹", "N-H stretching around 3300 cm⁻¹, C-N stretching around 1200 cm⁻¹"};
    public InfraredPeaks() {
        Console.WriteLine(" ");
    }
    public string ShowPeaks(index) {
        Console.WriteLine($"{_wavenumber[index]}");
        string wavenumber = _wavenumber[index];
        return wavenumber;
    }
}