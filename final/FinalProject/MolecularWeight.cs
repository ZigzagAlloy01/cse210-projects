public class MolecularWeight : Molecules {
    private List<string> _moleculesWeight = new List<string> {"32.04 g/mol", "46.07 g/mol", "60.10 g/mol", "74.12 g/mol", "88.15 g/mol", "58.08 g/mol", "72.11 g/mol", "72.11 g/mol", "86.13 g/mol", "100.16 g/mol", "78.11 g/mol", "92.14 g/mol", "106.16 g/mol", "128.17 g/mol", "178.23 g/mol", "46.03 g/mol", "60.05 g/mol", "74.08 g/mol", "88.11 g/mol", "102.13 g/mol", "30.03 g/mol", "44.05 g/mol", "58.08 g/mol", "72.11 g/mol", "86.14 g/mol", "93.13 g/mol", "107.15 g/mol", "73.14 g/mol", "59.11 g/mol", "85.15 g/mol"};
    public MolecularWeight() {
        Console.WriteLine(" ");
    }
    public string ShowWeight(int index) {
        string weight = _moleculesWeight[index];
        return weight;
    }
}