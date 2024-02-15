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

    [Test]
    [TestCase(11, ExpectedResult = true)]
    [TestCase(10, ExpectedResult = false)]
    public bool OddNumberCheck_Combined(int a)
    {
        //Arrange
        Calculator calculator = new();

        // Act
        var result = calculator.IsOddNumber(a);

        //Assert

        return result;
    }

    [Test]
    [TestCase(1.3, 4.0)]
    [TestCase(3.0, 2.0)]
    public void AddNumbers_Two_Doubles(double a, double b)
    {
        //Arrange

        Calculator calculator = new();

        //Act
        var result = calculator.AddNumbersDouble(a, b);

        //Assert
        // Assert.That(result, Is.EqualTo(5.3));
        Assert.AreEqual(5.3,result,1);
    }
}
