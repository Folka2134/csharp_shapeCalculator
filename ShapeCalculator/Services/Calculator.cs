namespace ShapeCalculator.Services
{
    public class Calculator : ICalculator
    {
        public double CalculatePerimeter(Shape shape)
        {
            return shape.Perimeter();
        }

        public double CalculateArea(Shape shape)
        {
            return shape.Area();
        }
    }
}
