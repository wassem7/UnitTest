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

        Assert.That(result, Is.EqualTo($"Hello {firstname} {lastname}"));
        Assert.That(result, Does.StartWith("Hello"));
        Assert.That(result, Does.Contain("wassem").IgnoreCase);
    }

    [Test]
    public void GreetandCombineNullChecker()
    {
        //Arrange
        // Customer customer = new();

        //Assert
        Assert.IsNull(customer.Greeting);
    }
}
