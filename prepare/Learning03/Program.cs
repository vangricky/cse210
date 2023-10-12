using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine("");

        // Using different constructors and running them:
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine(fraction2.GetFractionString());

        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine(fraction3.GetFractionString());

        Console.WriteLine("");
        //Getters and Setters
        fraction1.SetTop(50);
        fraction1.SetBottom(50);
        Console.WriteLine(fraction1.GetFractionString());

        fraction2.SetTop(100);
        Console.WriteLine(fraction2.GetFractionString());

        Console.WriteLine("");
        //GetDecimalValue
        Console.WriteLine(fraction1.GetDecimalValue());

        fraction2.SetTop(5);
        Console.WriteLine(fraction2.GetDecimalValue());

        fraction3.SetTop(1);
        fraction3.SetBottom(3);
        Console.WriteLine(fraction3.GetDecimalValue());

    }
}