using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class NUnitTest
{
    [Test]
    public void AddNumbers_TwoInts_GetCorrectAddtion()
    {
        //Arrange

        Calculator calculator = new();

        //Act
        var result = calculator.AddNumbers(10, 20);

        //Assert

        Assert.AreEqual(30, result);
    }

    [Test]
    public void OddNumberChecker_For_Even_Numbers_Return_False()
    {
        // Arrange
        Calculator calculator = new();

        //Act
        var result = calculator.IsOddNumber(2);
        // Act and Assert

        Assert.That(result, Is.False);
    }

    [Test]
    public void OddNumberChecker_For_Even_Numbers_Return_True()
    {
        //Arrange
        Calculator calculator = new();

        //Act
        var result = calculator.IsOddNumber(3);

        //Assert

        Assert.That(result, Is.True);
    }
}
