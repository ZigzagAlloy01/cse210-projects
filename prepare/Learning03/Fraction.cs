public class Fraction 
{
    private int _numerator;
    private int _denominator;
    public Fraction() {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int userNumber) {
        _numerator = userNumber;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator) {
        _numerator = numerator;
        _denominator = denominator;
    }
    public string WriteFraction() {
        string fraction = $"{_numerator}/{_denominator}";
        return fraction;
    }
    public double calculateFractionValue() {
        double decimalValue = (double)_numerator/(double)_denominator;
        return decimalValue;
    }
}