namespace SquareCalculator.Tests;

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
        double actual)
    {
        //arrange
        //act
        var square = Calculator.CalculateSquare(cathetusA,cathetusB,hypotenuse);
        //assert
        Assert.AreEqual(square, actual, 1E5);
    }
}