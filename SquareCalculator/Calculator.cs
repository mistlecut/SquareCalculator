namespace SquareCalculator;

public static class Calculator
{
    private const double ComparisonConst = 1E-5;

    private static bool IsTriangleCorrect(double sideA, double sideB, double sideC)
        => sideA >= 0 && sideB >= 0 && sideC >= 0;

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
        if(!IsTriangleCorrect(sideA, sideB, sideC))
            throw new ArgumentException($"Sides - {sideA}, {sideB}, {sideC}; should be grater then or equal 0");
            
        if (IsTriangleRight(sideA, sideB, sideC))
            return GetRightTriangleSquare(sideA, sideB, sideC);

        var halfPerimeter = sideA + (sideB - sideA + sideC) / 2;
            
        return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));   
    }

    private static bool IsCircleCorrect(double radius) 
        => radius >= 0;

    public static double CalculateSquare(double radius)
    {
        if(!IsCircleCorrect(radius))
            throw new ArgumentException($"Radius - {radius}; should be grater then or equal 0");
        
        return Math.PI * radius * radius;
    }
}