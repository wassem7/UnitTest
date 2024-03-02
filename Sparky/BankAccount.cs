namespace Sparky;

public class BankAccount
{
    private readonly ILogBook _logBook;
    private int _balance;

    public BankAccount(ILogBook logBook)
    {
        _logBook = logBook;
        _balance = 0;
    }

    public bool Deposit(int amount)
    {
        _logBook.Message("Deposit invoked...");
        _balance += amount;
        return true;
    }

    public bool Withdraw(int amount)
    {
        if (amount < _balance)
        {
            _logBook.LogToDb($"Amount requested to withdraw : {amount}");
            _balance -= amount;

            _logBook.LogBalanceAfterWithdrawl(_balance - amount);
        }

        return false;
    }

    public int GetBalance()
    {
        return _balance;
    }
}
