using Sparky;

namespace SparkyMSTest;

[TestClass]
public class CalculatorMsTest
{
    [TestMethod]
    public void Test_AddNumbers_TwoInts_GetCorrectResults()
    {
        //Arrange

        Calculator calc = new();
        //Act
        var result = calc.AddNumbers(10, 20);
        //Assert

        Assert.AreEqual(30, result);
    }
}
