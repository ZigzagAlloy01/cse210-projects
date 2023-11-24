public class Solubility : Nowhere {
    private List<string> _solubility = new List<string> {"Miscible in water", "Miscible in water", "Miscible in water", "~8.3 g/mL in water", "Insoluble or slightly soluble in water", "Miscible in water", "Miscible in water", "Miscible in water", "Miscible in water", "Miscible in water", "Insoluble in water", "Insoluble in water", "Insoluble in water", "Insoluble in water", "Insoluble in water", "Soluble in water", "Soluble in water", "Soluble in water", "Soluble in water", "Soluble in water", "Miscible in water", "Miscible in water", "Miscible in water", "Miscible in water", "Miscible in water", "~3 g/mL in water", "~4.7 g/mL in water", "Miscible in water", "Miscible in water", "Miscible in water"};
    public Density() {
        Console.WriteLine(" ");
    }
    public string ShowSolubility(index) {
        Console.WriteLine($"{_solubility[index]}");
        string solubility = _solubility[index];
        return solubility;
    }
}