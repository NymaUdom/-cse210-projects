using System.Collections.Generic;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold shapes
            List<Shape> shapes = new List<Shape>();

            // Add a square, rectangle, and circle to the list
            shapes.Add(new Square(5, "Red"));
            shapes.Add(new Rectangle(4, 6, "Blue"));
            shapes.Add(new Circle(3, "Green"));

            // Iterate through the list of shapes
            foreach (var shape in shapes)
            {
                // Display the color and area of each shape
                Console.WriteLine($"{shape.GetType().Name} Color: {shape.Color}");
                Console.WriteLine($"{shape.GetType().Name} Area: {shape.GetArea()}");
                Console.WriteLine();
            }
        }
    }
}
