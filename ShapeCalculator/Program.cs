using ShapeCalculator.Controllers;
using ShapeCalculator.Services;
using ShapeCalculator.Views;

namespace ShapeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new ConsoleView();
            var calculator = new Calculator();
            var controller = new CalculatorController(view, calculator);
            controller.Run();
        }
    }
}
