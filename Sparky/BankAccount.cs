namespace Sparky;

public class BankAccount
{
    private int _balance;

    public BankAccount()
    {
        _balance = 0;
    }

    public bool Deposit(int amount)
    {
        _balance += amount;
        return true;
    }

    public bool Withdraw(int amount)
    {
        if (amount < _balance)
        {
            _balance -= amount;

            return true;
        }

        return false;
    }

    public int GetBalance()
    {
        return _balance;
    }
}
