public class BoilingMelting : Nowhere {
    private List<string> _meltingPoints = new List<string> {"-97.6°C", "-114.1°C", "-126.2°C", "-88.6°C", "-78.2°C", "-94.7°C", "-86.3°C", "-86.3°C", "-65.5°C", "-57.8°C", "5.5°C", "-93°C", "-47°C", "80.2°C", "217°C", "8.4°C", "16.6°C", "-20.7°C", "-5.4°C", "6.2°C", "-92°C", "-123.5°C", "-81.5°C", "-99.8°C", "-56°C", "-6°C", "-57°C", "-49.7°C", "-117.9°C", "-13°C"};
    private List<string> _boilingPoints = new List<string> {"64.7°C", "78.4°C", "97.2°C", "117.7°C", "138.0°C", "56.1°C", "79.6°C", "79.6°C", "101.3°C", "130.6°C", "80.1°C", "110.6°C", "144°C", "218°C", "340°C", "100.8°C", "118.1°C", "141.1°C", "163.5°C", "186.2°C", "-19°C", "20.8°C", "48.5°C", "75.8°C", "103.8°C", "184.1°C", "194°C", "55.7°C", "-6.9°C", "106°C"};
    public BoilingMelting() {
        Console.WriteLine(" ");
    }
    public string ShowPoints(index) {
        Console.WriteLine($"Melting Point: {_meltingPoints[index]}; Boiling Point: {_boilingPoints[index]}");
        string points = $"Melting Point: {_meltingPoints[index]}; Boiling Point: {_boilingPoints[index]}";
        return points;
    }
}