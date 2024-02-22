using Moq;
using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class BankAccountNUnitTests
{
    private BankAccount _account;

    [SetUp]
    public void SetUp() { }

    [Test]
    public void BankDepositLog_Fakker_Test_Return_True()
    {
        BankAccount bankAccount = new(new LogFakker());
        var result = bankAccount.Deposit(100);

        Assert.IsTrue(result);
    }

    [Test]
    public void BankDeposit_Test_Return_True()
    {
        var logMock = new Mock<ILogBook>();
        BankAccount bankAccount = new BankAccount(logMock.Object);

        var result = bankAccount.Deposit(1);
        Assert.IsTrue(result);
    }
}
