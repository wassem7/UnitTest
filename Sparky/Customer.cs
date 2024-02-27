namespace Sparky;

public interface ICustomer
{
    public string Greeting { get; set; }
    public int OrderTotal { get; set; }
    public int Discount { get; set; }
    public bool IsPlatinum { get; set; }

    public string GreetAndCombineNames(string firstname, string lastname);
    public CustomerType GetCustomerDetails();
}

public class Customer : ICustomer
{
    public string Greeting { get; set; }

    public int OrderTotal { get; set; }

    public int Discount { get; set; }
    public bool IsPlatinum { get; set; }

    public Customer()
    {
        IsPlatinum = false;
        Discount = 15;
        OrderTotal = 12;
    }

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
}

public class CustomerType { }

public class PlatinumCustomer : CustomerType { }

public class BasicCustomer : CustomerType { }
