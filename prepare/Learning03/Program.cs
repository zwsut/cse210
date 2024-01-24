using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction fraction1 = new Fraction();
        // Fraction fraction2 = new Fraction(3);
        // Fraction fraction3 = new Fraction(5,7);
        // Console.WriteLine($"{fraction1.GetFractionString()}\n{fraction2.GetFractionString()}\n{fraction3.GetFractionString()}");

        Fraction f4 = new Fraction();
        f4.SetTop(1);
        f4.SetBottom(1);
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine(f4.GetFractionString());

        Fraction f5 = new Fraction();
        f5.SetTop(5);
        f5.SetBottom(1);
        Console.WriteLine(f5.GetDecimalValue());
        Console.WriteLine(f5.GetFractionString());

        Fraction f6 = new Fraction();
        f6.SetTop(3);
        f6.SetBottom(4);
        Console.WriteLine(f6.GetDecimalValue());
        Console.WriteLine(f6.GetFractionString());

        Fraction f7 = new Fraction();
        f7.SetTop(1);
        f7.SetBottom(3);
        Console.WriteLine(f7.GetDecimalValue());
        Console.WriteLine(f7.GetFractionString());
    }
}