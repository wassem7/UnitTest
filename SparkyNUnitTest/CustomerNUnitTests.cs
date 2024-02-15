using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class CustomerNUnitTests
{
    [Test]
    [TestCase("Wassem", "Darkwa")]
    public void GreetandCombineUnitTests(string firstname, string lastname)
    {
        //Arrange

        Customer customer = new();

        //Act

        var result = customer.GreetAndCombineNames(firstname, lastname);

        Assert.That(result, Is.EqualTo($"Hello {firstname} {lastname}"));
    }
}
