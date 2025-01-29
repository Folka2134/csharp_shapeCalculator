namespace ShapeCalculator.Services
{
    public abstract class Shape
    {
        public abstract double Perimeter();
        public abstract double Area();

        private string _name;
        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }
    }
}
