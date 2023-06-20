using SquareCalculatorFactory.Figures.Interfaces;

namespace SquareCalculatorFactory.Figures;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public bool IsFigureCorrect()
        => _radius >= 0;

    public double GetSquare()
        => Math.PI * _radius * _radius;
}