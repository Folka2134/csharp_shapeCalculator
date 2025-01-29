namespace ShapeCalculator.Views
{
    public interface IConsoleView
    {
        void DisplayMessage(string message);
        string UserInput();
    }
}
