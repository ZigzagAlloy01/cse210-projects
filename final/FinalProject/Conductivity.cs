public class Conductivity : Molecules {
    private List<string> _pKa = new List<string> {"Low electrical conductivity"};

    public Conductivity() {
        Console.WriteLine(" ");
    }
    public string ShowElectricalBehavior(int index) {
        int i = index * 0;
        string pKa = $"pKa: {_pKa[i]}";
        return pKa;
    }
}