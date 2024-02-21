namespace Sparky;

public class Customer
{
    public string Greeting { get; set; }

    public int OrderTotal = 12;
    public int Discount = 15;

    public string GreetAndCombineNames(string firstname, string lastname)
    {
        Discount = 20;

        if (string.IsNullOrWhiteSpace(firstname))
        {
            throw new ArgumentException("Empty firstname");
        }
        Greeting = $"Hello {firstname} {lastname}";
        return Greeting;
    }

    public CustomerType GetCustomerDetails()
    {
        if (OrderTotal < 100)
        {
            return new PlatinumCustomer();
        }

        return new BasicCustomer();
    }

    public class CustomerType { }

    public class PlatinumCustomer : CustomerType { }

    public class BasicCustomer : CustomerType { }
}
