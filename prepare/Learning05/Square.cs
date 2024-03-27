namespace ShapeCalculator
{
    // Square class
    public class Square : Shape
    {
        private double _side;

        // Constructor
        public Square(double side, string color) : base(color)
        {
            _side = side;
        }

        // Override method to calculate the area of the square
        public override double GetArea()
        {
            return _side * _side;
        }
    }
}
