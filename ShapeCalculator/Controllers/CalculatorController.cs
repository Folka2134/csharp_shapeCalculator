using ShapeCalculator.Services;
using ShapeCalculator.Views;

namespace ShapeCalculator.Controllers
{
    public class CalculatorController
    {
        private readonly IConsoleView _consoleView;
        private readonly ICalculator _calculator;

        public CalculatorController(IConsoleView consoleView, ICalculator calculator)
        {
            _consoleView = consoleView;
            _calculator = calculator;
        }

        public void Run()
        {
            _consoleView.DisplayMessage("Welcome to the Shape Calculator!");

            while (true)
            {
                _consoleView.DisplayMessage("Please enter the dimensions of your shape. Or Exit to quit.");
                string input = _consoleView.UserInput();

                if (input.ToLower() == "exit")
                {
                    _consoleView.DisplayMessage("Calcuator off.");
                    break;
                }

                // determine shape based on input, 1 input is a circle, 2 inputs is a rectangle, 3 inputs is a triangle
                string[] dimensions = input.Split(',');
                Shape shape = null;
                if (dimensions.Length == 1)
                {
                    shape = new Circle(double.Parse(dimensions[0]));
                }
                else if (dimensions.Length == 2)
                {
                    shape = new Rectangle(double.Parse(dimensions[0]), double.Parse(dimensions[1]));
                }
                else if (dimensions.Length == 3)
                {
                    shape = new Triangle(double.Parse(dimensions[0]), double.Parse(dimensions[1]), double.Parse(dimensions[2]));
                }
                else
                {
                    _consoleView.DisplayMessage("Invalid input. Please try again.");
                    continue;
                }

                _consoleView.DisplayMessage($"The perimeter of your {shape.Name} is: {_calculator.CalculatePerimeter(shape)}");
                _consoleView.DisplayMessage($"The area of your {shape.Name} is: {_calculator.CalculateArea(shape)}");
            }
        }

    }
}
