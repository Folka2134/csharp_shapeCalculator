namespace ShapeCalculator.Services
{
    public interface ICalculator
    {
        double CalculatePerimeter(Shape shape);
        double CalculateArea(Shape shape);
    }
}
