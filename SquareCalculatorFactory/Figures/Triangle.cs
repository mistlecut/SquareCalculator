using SquareCalculatorFactory.Figures.Interfaces;

namespace SquareCalculatorFactory.Figures;

public class Triangle : IFigure
{
    private const double ComparisonConst = 1E-5;
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;
    private readonly double _halfPerimeter;
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
        _halfPerimeter = _sideA + (_sideB - _sideA + _sideC) / 2;
    }

    public bool IsFigureCorrect()
        => _sideA >= 0 && _sideB >= 0 && _sideC >= 0;

    private bool IsTriangleRight()
        => (Math.Abs(_sideA * _sideA - (_sideC * _sideC + _sideB * _sideB)) < ComparisonConst
            || Math.Abs(_sideB * _sideB - (_sideC * _sideC + _sideA * _sideA)) < ComparisonConst
            || Math.Abs(_sideB * _sideB - (_sideC * _sideC + _sideA * _sideA)) < ComparisonConst);

    private double GetRightTriangleSquare()
    {
        var hypotenuse  = new []{_sideA, _sideB, _sideC}.Max();
        if (Math.Abs(hypotenuse - _sideA) < ComparisonConst)
            return _sideB * _sideC / 2;
        if (Math.Abs(hypotenuse - _sideB) < ComparisonConst)
            return _sideA * _sideC / 2;
        return _sideA * _sideB / 2;
    }
    
    public double GetSquare()
    {
        if (IsTriangleRight())
            return GetRightTriangleSquare();
        
        return Math.Sqrt(_halfPerimeter * (_halfPerimeter - _sideA) * (_halfPerimeter - _sideB) * (_halfPerimeter - _sideC));
    }
}