namespace BuildApp.UnitTests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void FirstTestMethod()
    {
        // Arrange
        int expectedResult = 20;

        // Act
        int actualResult = 2;

        // Assert
        Assert.IsTrue(expectedResult == actualResult);
    }
}