using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class ProductNUnitTests
{
    private Customer customer;

    [SetUp]
    public void Setup()
    {
        customer = new Customer();
    }

    [Test]
    public void GetProductPrice_With_Discount_20_percent()
    {
        var product = new Product() { Price = 50 };

        var result = product.GetPrice(new Customer() { IsPlatinum = true });

        Assert.That(result, Is.EqualTo(40));
    }
}
