namespace Sparky;

public class Customer
{
    public string Greeting { get; set; }

    public string GreetAndCombineNames(string firstname, string lastname)
    {
        Greeting = $"Hello {firstname} {lastname}";
        return Greeting;
    }
}
