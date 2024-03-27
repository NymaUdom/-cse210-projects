namespace ShapeCalculator
{
    // Rectangle class
    public class Rectangle : Shape
    {
        private double _length;
        private double _width;

        // Constructor
        public Rectangle(double length, double width, string color) : base(color)
        {
            _length = length;
            _width = width;
        }

        // Override method to calculate the area of the rectangle
        public override double GetArea()
        {
            return _length * _width;
        }
    }
}
