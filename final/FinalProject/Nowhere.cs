public abstract class Nowhere {
    private List<string> _moleculesName = new List<string> {"Methanol", "Ethanol", "Propanol", "Butanol", "Pentanol", "Acetone", "Methyl ethyl ketone", "Butanone", "Pentan-3-one", "Hexan-2-one", "Benzene", "Toluene", "Xylene", "Naphthalene", "Anthracene", "Formic Acid", "Acetic Acid", "Propionic Acid", "Butyric Acid", "Pentanoic Acid", "Formaldehyde", "Acetaldehyde", "Propionaldehyde", "Butyraldehyde", "Pentanal", "Aniline", "2-Methylaniline", "Diethylamine", "Trimethylamine", "Piperidine"};
    private List<string> _moleculesFormula = new List<string> {"CH₃OH", "C₂H₅OH", "C₃H₇OH", "C₄H₉OH", "C₅H₁₁OH", "CH₃COCH₃", "C₄H₈O", "C₄H₈O", "C₅H₁₀O", "C₆H₁₂O", "C₆H₆", "C₇H₈", "C₈H₁₀", "C₁₀H₈", "C₁₄H₁₀", "HCOOH", "CH₃COOH", "C₂H₅COOH", "C₃H₇COOH", "C₄H₉COOH", "CH₂O", "CH₃CHO", "C₃H₇CHO", "C₄H₉CHO", "C₅H₁₁CHO", "C₆H₅NH₂", "C₇H₉NH₂", "C₄H₁₁N", "C₃H₉N", "C₅H₁₁N"};
    private List<string> _feature = new List<string> {"Molecular Weight", "Density", "Boiling and Melting Point", "Infrared Peaks", "Solubility", "Acidity/Basicity", "Electrophilic/Nucleophilic Character", "Conductivity", "Display All"};
    int _userNumber;

    public int DisplayMenu() {
        Console.WriteLine(" ");
        Console.WriteLine("Molecules: ");
        for (int i = 0; i < _moleculesName.Count; i++) {
            Console.WriteLine($"{i+1}. {_moleculesName[i]} ({_moleculesFormula[i]})");
        }
        Console.WriteLine(" ");
        Console.Write("Select the index of a molecule: ");
        string userInput = Console.ReadLine();
        _userNumber = int.Parse(userInput);
        return _userNumber - 1;
    }
    public int ChooseFeature() {
        Console.WriteLine(" ");
        Console.WriteLine("Features: ");
        for (int i = 0; i < _feature.Count; i++) {
            Console.WriteLine($"{i+1}. {_feature[i]}");
        }
        Console.WriteLine(" ");
        Console.Write("Select the index of a feature: ");
        string userInput = Console.ReadLine();
        _userNumber = int.Parse(userInput);
        return _userNumber;
    }
}