﻿namespace Sparky;

public interface ILogBook
{
    public void Message(string message);

    public bool LogToDb(string message);

    public bool LogBalanceAfterWithdrawl(int balanceAfterWithdrawl);
}

public class LogBook : ILogBook
{
    public void Message(string message)
    {
        Console.WriteLine(message);
    }

    public bool LogToDb(string message)
    {
        Console.WriteLine(message);

        return true;
    }

    public bool LogBalanceAfterWithdrawl(int balanceAfterWithdrawl)
    {
        if (balanceAfterWithdrawl >= 0)
        {
            Console.WriteLine("Success");
            return true;
        }

        Console.WriteLine("failure");
        return false;
    }
}
