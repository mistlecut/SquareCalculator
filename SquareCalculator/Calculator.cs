namespace SquareCalculator;

public static class Calculator
{
    private const double ComparisonConst = 1E-5;
    
    private static bool IsTriangleRight(double sideA, double sideB, double sideC)
        => (Math.Abs(sideA * sideA - (sideC * sideC + sideB * sideB)) < ComparisonConst
            || Math.Abs(sideB * sideB - (sideC * sideC + sideA * sideA)) < ComparisonConst
            || Math.Abs(sideB * sideB - (sideC * sideC + sideA * sideA)) < ComparisonConst);

    private static double GetRightTriangleSquare(double sideA, double sideB, double sideC)
    {
        var hypotenuse  = new []{sideA, sideB, sideC}.Max();
        if (Math.Abs(hypotenuse - sideA) < ComparisonConst)
            return sideB * sideC / 2;
        if (Math.Abs(hypotenuse - sideB) < ComparisonConst)
            return sideA * sideC / 2;
        return sideA * sideB / 2;
    }
    
    public static double CalculateSquare(double sideA, double sideB, double sideC)
    {
        if (IsTriangleRight(sideA, sideB, sideC))
            return GetRightTriangleSquare(sideA, sideB, sideC);

        var halfPerimeter = sideA / 2 + sideB / 2 + sideC / 2;
            
        return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));   
    }

    public static double CalculateSquare(double radius)
        => Math.PI * radius * radius;
}