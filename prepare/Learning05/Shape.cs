namespace ShapeCalculator
{
    // Base class for all shapes
    public class Shape
    {
        private string _color;

        // Constructor
        public Shape(string color)
        {
            _color = color;
        }

        // Property to get and set the color
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        // Virtual method to get the area (to be overridden by derived classes)
        public virtual double GetArea()
        {
            return 0; // Default implementation returns 0
        }
    }
}
