namespace ShapeCalculator.Services
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
            Name = "Circle";
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }

        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
