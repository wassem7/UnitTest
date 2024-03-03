using Xunit;

namespace Sparky;

public class CustomerXUnitTests
{
    private Customer customer;

    // [SetUp]
    // public void SetUp()
    // {
    //     customer = new Customer();
    // }

    [Theory]
    [InlineData("Wassem", "Darkwa")]
    public void GreetandCombineUnitTests(string firstname, string lastname)
    {
        //Arrange

        // Customer customer = new();

        //Act

        var result = customer.GreetAndCombineNames(firstname, lastname);

        //Assert

        Assert.Equal(result, $"Hello {firstname} {lastname}");
        Assert.StartsWith("Hello", result);
        Assert.Contains(result, "wassem", StringComparison.OrdinalIgnoreCase);
    }

    [Fact]
    public void GreetandCombineNullChecker()
    {
        //Arrange
        // Customer customer = new();

        //Assert
        Assert.Null(customer.Greeting);
    }

    [Fact]
    public void Customer_Discount_Range_Test()
    {
        var result = customer.Discount;

        Assert.InRange(result, 15, 25);
    }

    [Fact]
    public void Customer_Greeting_Exception_Test()
    {
        //Assert Exception Message
        var exception = Assert.Throws<ArgumentException>(
            () => customer.GreetAndCombineNames("", "Darkwa")
        );

        //Assert only Exception

        Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Darkwa"));
        Assert.Equal("Empty firstname", exception.Message);
    }

    [Fact]
    public void CustomerTypeUnitTest_Return_PlantinumCustomer()
    {
        customer.OrderTotal = 5;

        var result = customer.GetCustomerDetails();

        Assert.IsType<PlatinumCustomer>(result);
    }
}
