using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of the Fraction class and displaying results
            Fraction f1 = new Fraction();
            Console.WriteLine(f1.GetFractionString());
            Console.WriteLine(f1.GetDecimalValue());

            Fraction f2 = new Fraction(5);
            Console.WriteLine(f2.GetFractionString());
            Console.WriteLine(f2.GetDecimalValue());

            Fraction f3 = new Fraction(3, 4);
            Console.WriteLine(f3.GetFractionString());
            Console.WriteLine(f3.GetDecimalValue());

            Fraction f4 = new Fraction(1, 3);
            Console.WriteLine(f4.GetFractionString());
            Console.WriteLine(f4.GetDecimalValue());

            // Testing new constructors and methods
            Fraction f5 = new Fraction();        // 1/1
            Console.WriteLine(f5.GetFractionString());
            Console.WriteLine(f5.GetDecimalValue());

            Fraction f6 = new Fraction(6);       // 6/1
            Console.WriteLine(f6.GetFractionString());
            Console.WriteLine(f6.GetDecimalValue());

            Fraction f7 = new Fraction(6, 7);    // 6/7
            Console.WriteLine(f7.GetFractionString());
            Console.WriteLine(f7.GetDecimalValue());

            // Testing getters and setters
            f7.Top = 8;
            f7.Bottom = 9;
            Console.WriteLine(f7.GetFractionString());
            Console.WriteLine(f7.GetDecimalValue());
        }
    }
}