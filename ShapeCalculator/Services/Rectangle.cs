namespace ShapeCalculator.Services
{
    public class Rectangle : Shape
    {
        private double _length;
        private double _width;

        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
            Name = "Rectangle";
        }

        public override double Perimeter()
        {
            return (_length + _width) * 2;
        }

        public override double Area()
        {
            return _length * _width;
        }
    }
}
