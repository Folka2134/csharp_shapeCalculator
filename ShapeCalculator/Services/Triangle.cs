namespace ShapeCalculator.Services
{
    public class Triangle : Shape
    {
        public double _side1;
        public double _side2;
        public double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            Name = "Triangle";
        }

        public override double Perimeter()
        {
            return _side1 + _side2 + _side3;
        }

        public override double Area()
        {
            return 0.5 * (_side1 * _side2);
        }

    }
}
