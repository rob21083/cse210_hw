using System;

class Program
{
    static void Main(string[] args)
    {
        fraction f1 = new fraction();
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());
        
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        f1.SetTop(5);
        f1.SetBottom(6);

        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
    }
}