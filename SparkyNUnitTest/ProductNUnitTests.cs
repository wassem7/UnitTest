using Moq;
using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class ProductNUnitTests
{
    [Test]
    public void GetProductPrice_With_Discount_20_percent()
    {
        var product = new Product() { Price = 50 };
        var customer = new Mock<ICustomer>();
        customer.Setup(c => c.IsPlatinum).Returns(true);

        var result = product.GetPrice(customer.Object);

        Assert.That(result, Is.EqualTo(40));
    }
}
