namespace ShapeCalculator
{
    // Circle class
    public class Circle : Shape
    {
        private double _radius;

        // Constructor
        public Circle(double radius, string color) : base(color)
        {
            _radius = radius;
        }

        // Override method to calculate the area of the circle
        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
