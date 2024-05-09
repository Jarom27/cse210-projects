using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number1 = new Fraction();
        Fraction number2 = new(6);
        Fraction number3 = new(6, 7);

        Fraction number4 = new(3, 4);
        Fraction number5 = new(5);
        Fraction number6 = new(1, 3);

        Console.WriteLine(number1.GetFractionString());
        Console.WriteLine(number1.GetDecimalValue());
        Console.WriteLine(number4.GetFractionString());
        Console.WriteLine(number4.GetDecimalValue());
        Console.WriteLine(number5.GetFractionString());
        Console.WriteLine(number5.GetDecimalValue());
        Console.WriteLine(number6.GetFractionString());
        Console.WriteLine(number6.GetDecimalValue());
    }
}