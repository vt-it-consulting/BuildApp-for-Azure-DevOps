using BuildApp.Modules;

namespace BuildApp.UnitTests;

[TestClass]
public class MathsCalculator
{
    private Calculator calculator;

    [TestInitialize]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [TestMethod]
    public void Add_ShouldReturnSumOfTwoNumbers()
    {
        double result = calculator.Add(2, 3);
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Subtract_ShouldReturnDifferenceOfTwoNumbers()
    {
        double result = calculator.Subtract(5, 3);
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void Multiply_ShouldReturnProductOfTwoNumbers()
    {
        double result = calculator.Multiply(2, 3);
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void Divide_ShouldReturnQuotientOfTwoNumbers()
    {
        double result = calculator.Divide(6, 3);
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Divide_ShouldThrowDivideByZeroException_WhenDividingByZero()
    {
        calculator.Divide(6, 0);
    }
}