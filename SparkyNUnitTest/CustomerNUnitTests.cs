using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class CustomerNUnitTests
{
    private Customer customer;

    [SetUp]
    public void SetUp()
    {
        customer = new Customer();
    }

    [Test]
    [TestCase("Wassem", "Darkwa")]
    public void GreetandCombineUnitTests(string firstname, string lastname)
    {
        //Arrange

        // Customer customer = new();

        //Act

        var result = customer.GreetAndCombineNames(firstname, lastname);

        //Assert

        Assert.Multiple(
            (
                () =>
                {
                    Assert.That(result, Is.EqualTo($"Hello a{firstname} {lastname}"));
                    Assert.That(result, Does.StartWith("Hello"));
                    Assert.That(result, Does.Contain("wassem").IgnoreCase);
                }
            )
        );
    }

    [Test]
    public void GreetandCombineNullChecker()
    {
        //Arrange
        // Customer customer = new();

        //Assert
        Assert.IsNull(customer.Greeting);
    }

    [Test]
    public void Customer_Discount_Range_Test()
    {
        var result = customer.Discount;

        Assert.That(result, Is.InRange(15, 25));
    }

    [Test]
    public void Customer_Greeting_Exception_Test()
    {
        //Assert Exception Message
        var exception = Assert.Throws<ArgumentException>(
            () => customer.GreetAndCombineNames("", "Darkwa")
        );

        //Assert only Exception

        Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Darkwa"));
        Assert.That("Empty firstname", Is.EqualTo(exception.Message));
    }
}
