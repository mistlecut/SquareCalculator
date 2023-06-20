using SquareCalculatorFactory.Figures.Interfaces;

namespace SquareCalculatorFactory;

public static class Calculator
{
    public static double GetSquare<T>(T figure) where T : IFigure
    {
        if(!figure.IsFigureCorrect())
            throw new ArgumentException($"{typeof(T)} params should be grater then or equal  0");

        return figure.GetSquare();
    }
}