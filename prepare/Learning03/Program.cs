using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.WriteFraction());
        Console.WriteLine(f1.calculateFractionValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.WriteFraction());
        Console.WriteLine(f2.calculateFractionValue());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.WriteFraction());
        Console.WriteLine(f3.calculateFractionValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.WriteFraction());
        Console.WriteLine(f4.calculateFractionValue());
    }
}