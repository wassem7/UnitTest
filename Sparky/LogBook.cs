namespace Sparky;

public interface ILogBook
{
    public void Message(string message);
}

public class LogBook : ILogBook
{
    public void Message(string message)
    {
        Console.WriteLine(message);
    }
}

public class LogFakker : ILogBook
{
    public void Message(string message) { }
}
