using SquareCalculatorFactory.Figures.Interfaces;

namespace SquareCalculatorFactory;

public static class Calculator<T> where T : IFigure
{
    public static double GetSquare(T figure)
    {
        if(!figure.IsFigureCorrect())
            throw new ArgumentException($"{typeof(T)} params should be grater then or equal  0");

        return figure.GetSquare();
    }
}