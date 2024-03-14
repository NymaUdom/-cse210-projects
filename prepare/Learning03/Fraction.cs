using System;

namespace MathOperations
{
    // Definition of the Fraction class
    public class Fraction
    {
        private int _top;     // Numerator
        private int _bottom;  // Denominator

        // Default constructor, initializes fraction to 1/1
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        // Constructor for whole numbers
        public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom = 1;
        }

        // Constructor for custom fractions
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        // Getter and Setter for the top value
        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }

        // Getter and Setter for the bottom value
        public int Bottom
        {
            get { return _bottom; }
            set { _bottom = value; }
        }

        // Method to get the string representation of the fraction
        public string GetFractionString()
        {
            string text = $"{_top}/{_bottom}";
            return text;
        }

        // Method to get the decimal value of the fraction
        public double GetDecimalValue()
        {
            return (double)_top / (double)_bottom;
        }
    }
}

