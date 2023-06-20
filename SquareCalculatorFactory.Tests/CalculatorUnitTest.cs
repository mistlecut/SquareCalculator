using SquareCalculatorFactory.Figures;

namespace SquareCalculatorFactory.Tests;

public class Tests
{
    [Test]
    [TestCase(3, 4, 5, 6)]
    [TestCase(5, 4, 3, 6)]
    [TestCase(3, 5, 4, 6)]
    [TestCase(5.196, 3, 6, 7.794)]
    public void TriangleSquareCalculator_RightTriangle_Success(double cathetusA,
        double cathetusB,
        double hypotenuse,
        double expectedSquare)
    {
        //arrange
        var triangle = new Triangle(cathetusA, cathetusB, hypotenuse);
        //act
        var square = Calculator.GetSquare(triangle);
        //assert
        Assert.AreEqual(expectedSquare, square, 1E5);
    }
    
    [Test]
    [TestCase(6, 6, 6, 15.588)]
    [TestCase(0, 1, 1, 0)]
    [TestCase(1, 0, 1, 0)]
    [TestCase(1, 1, 0, 0)]
    [TestCase(0, 0, 0, 0)]
    public void TriangleSquareCalculator_NormalTriangle_Success(double cathetusA,
        double cathetusB,
        double hypotenuse,
        double expectedSquare)
    {
        //arrange
        var triangle = new Triangle(cathetusA, cathetusB, hypotenuse);
        
        //act
        var square = Calculator.GetSquare(triangle);
        
        //assert
        Assert.AreEqual(expectedSquare, square, 1E5);
    }

    [Test]
    public void TriangleSquareCalculator_IncorrectTriangle_Throw()
    {
        //arrange
        var triangle = new Triangle(-1, 0, 0);

        //act, assert
        Assert.Throws<ArgumentException>(() => Calculator.GetSquare(triangle));
    }

    [Test]
    [TestCase(1, 3.14)]
    [TestCase(2.5, 19.625)]
    [TestCase(0, 0)]
    public void  CircleSquareCalculator_RightCircle_Success(double radius, double expectedSquare)
    {
        //arrange
        var circle = new Circle(radius);
        //act
        var square = Calculator.GetSquare(circle);
        //assert
        Assert.AreEqual(expectedSquare, square, 1E5);
    }
    
    [Test]
    public void CircleSquareCalculator_IncorrectCircle_Throw()
    {
        //arrange
        var circle = new Circle(-1);

        //act, assert
        Assert.Throws<ArgumentException>(() => Calculator.GetSquare(circle));
    }
}