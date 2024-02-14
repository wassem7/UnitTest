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
    [TestCase(2)]
    [TestCase(4)]
    public void OddNumberChecker_For_Even_Numbers_Return_False(int a)
    {
        // Arrange
        Calculator calculator = new();

        //Act
        var result = calculator.IsOddNumber(a);
        // Act and Assert

        Assert.That(result, Is.False);
    }

    [Test]
    [TestCase(3)]
    [TestCase(5)]
    public void OddNumberChecker_For_Even_Numbers_Return_True(int b)
    {
        //Arrange
        Calculator calculator = new();

        //Act
        var result = calculator.IsOddNumber(b);

        //Assert

        Assert.That(result, Is.True);
    }
}
