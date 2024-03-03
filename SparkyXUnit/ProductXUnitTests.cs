using Moq;
using Xunit;

namespace Sparky;

public class ProductXUnitTests
{
    [Fact]
    public void GetProductPrice_With_Discount_20_percent()
    {
        var product = new Product() { Price = 50 };
        var customer = new Mock<ICustomer>();
        customer.Setup(c => c.IsPlatinum).Returns(true);

        var result = product.GetPrice(customer.Object);

        Assert.Equal(result, 40);
    }
}
