using System.Security.Cryptography;
using Microsoft.VisualBasic;

public abstract class Molecules {
    protected List<string> _moleculesFormula = new List<string> {"CH3OH", "C2H5OH", "C3H7OH", "C4H9OH", "C5H11OH", "CH3COCH3", "C4H8O", "C4H8O", "C5H10O", "C6H12O", "C6H6", "C7H8", "C8H10", "C10H8", "C14H10", "HCOOH", "CH3COOH", "C2H5COOH", "C3H7COOH", "C4H9COOH", "CH2O", "CH3CHO", "C3H7CHO", "C4H9CHO", "C5H11CHO", "C6H5NH2", "C7H9NH2", "C4H11N", "C3H9N", "C5H11N"};
    protected List<string> _moleculesName = new List<string> {"Methanol", "Ethanol", "Propanol", "Butanol", "Pentanol", "Acetone", "Methyl ethyl ketone", "Butanone", "Pentan-3-one", "Hexan-2-one", "Benzene", "Toluene", "Xylene", "Naphthalene", "Anthracene", "Formic Acid", "Acetic Acid", "Propionic Acid", "Butyric Acid", "Pentanoic Acid", "Formaldehyde", "Acetaldehyde", "Propionaldehyde", "Butyraldehyde", "Pentanal", "Aniline", "2-Methylaniline", "Diethylamine", "Trimethylamine", "Piperidine"};
    private List<string> _feature = new List<string> {"Acidity/Basicity", "Boiling and Melting Point", "Conductivity", "Density", "Electrophilic/Nucleophilic Character", "Infrared Peaks", "Molecular Weight", "Solubility", "Display All"};
    bool _cycle;
    int _menuNumber;
    int _featureNumber;
    public bool Welcome() {
        Console.WriteLine("Welcome to the Database of the Chemical and Physical Properties of Molecules!");
        Console.Write("Press Enter to see the list of molecules ");
        var userInput = Console.ReadKey();
        if(userInput.Key == ConsoleKey.Enter) {
            _cycle = true;
        }
        else {
            _cycle = false;
        }
        return _cycle;
    }
    public int DisplayMenu() {
        Console.WriteLine(" ");
        Console.WriteLine("Molecules: ");
        for (int i = 0; i < _moleculesName.Count; i++) {
            Console.WriteLine($"{i+1}. {_moleculesName[i]} ({_moleculesFormula[i]})");
        }
        Console.WriteLine(" ");
        Console.Write("Select the index of a molecule: ");
        string userInput = Console.ReadLine();
        _menuNumber = int.Parse(userInput);
        Console.WriteLine(" ");
        if (_menuNumber > 0 && _menuNumber < 31) {
            return _menuNumber - 1;
        }
        else {
            return -1;
        }
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
        _featureNumber = int.Parse(userInput);
        return _featureNumber - 1;
    }
    public bool Reload() {
        Console.WriteLine("Press Enter to go back to the Menu, or Q to quit");
        var userInput = Console.ReadKey();
        if(userInput.Key == ConsoleKey.Enter) {
            _cycle = true;
        }
        else if(userInput.Key == ConsoleKey.Q) {
            _cycle = false;
        }
        return _cycle;
    }
    public abstract string GetFeatureInformation(int moleculeIndex);
    public abstract string GetName(int moleculeIndex);
}