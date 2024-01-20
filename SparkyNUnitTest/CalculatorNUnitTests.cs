using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class CalculatorNUnitTests
{
    [Test]
    public void AddNumbers_TwoInts_GetCorrectAnswer()
    {
        //Arrange
        Calculator calculator = new();
        //Act
        var result = calculator.AddNumbers(10, 20);
        //Assert

        Assert.AreEqual(30, result);
    }
}
