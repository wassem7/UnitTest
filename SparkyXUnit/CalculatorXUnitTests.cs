using Xunit;

namespace Sparky;

public class NUnitTest
{
    private Calculator calculator;

    // public void SetUp()
    // {
    //     calculator = new Calculator();
    // }

    [Fact]
    public void AddNumbers_TwoInts_GetCorrectAddtion()
    {
        //Arrange

        Calculator calculator = new();

        //Act
        var result = calculator.AddNumbers(10, 20);

        //Assert

        Assert.Equal(30, result);
    }

    [Theory]
    [InlineData(2)]
    public void OddNumberChecker_For_Even_Numbers_Return_False(int a)
    {
        // Arrange
        Calculator calculator = new();

        //Act
        var result = calculator.IsOddNumber(a);
        // Act and Assert

        Assert.False(result);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    public void OddNumberChecker_For_Even_Numbers_Return_True(int b)
    {
        //Arrange
        Calculator calculator = new();

        //Act
        var result = calculator.IsOddNumber(b);

        //Assert

        Assert.True(result);
    }

    [Theory]
    [InlineData(11, true)]
    [InlineData(10, false)]
    public bool OddNumberCheck_Combined(int a, bool expectedResult)
    {
        //Arrange
        Calculator calculator = new();

        // Act
        var result = calculator.IsOddNumber(a);

        //Assert

        return result;
    }

    [Theory]
    [InlineData(1.3, 4.0)]
    [InlineData(3.0, 2.0)]
    public void AddNumbers_Two_Doubles(double a, double b)
    {
        //Arrange

        Calculator calculator = new();

        //Act
        var result = calculator.AddNumbersDouble(a, b);

        //Assert
        // Assert.That(result, Is.EqualTo(5.3));
        Assert.Equal(5.3, result, 1);
    }

    [Theory]
    [InlineData(5, 10)]
    public void OddNumberRange_Min_Max(int min, int max)
    {
        //Act
        List<int> expectedResults = new List<int>() { 5, 7, 9 };
        var result = calculator.GetOddNumberRange(min, max);

        Assert.Equal(result, expectedResults);
    }
}
