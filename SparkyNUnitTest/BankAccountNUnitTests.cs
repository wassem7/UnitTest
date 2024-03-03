using Moq;
using NUnit.Framework;

namespace Sparky;

[TestFixture]
public class BankAccountNUnitTests
{
    private BankAccount _account;

    [SetUp]
    public void SetUp() { }

    // [Test]
    // public void BankDepositLog_Fakker_Test_Return_True()
    // {
    //     BankAccount bankAccount = new(new LogFakker());
    //     var result = bankAccount.Deposit(100);
    //
    //     Assert.IsTrue(result);
    // }

    [Test]
    public void BankDeposit_Test_Return_True()
    {
        var logMock = new Mock<ILogBook>();
        BankAccount bankAccount = new BankAccount(logMock.Object);

        var result = bankAccount.Deposit(1);
        Assert.IsTrue(result);
    }

    [Test]
    [TestCase(300, 300)]
    public void BankWithdrawl_Balance_of_300_Withdrawl_of_100(int balance, int amount)
    {
        var loggerMock = new Mock<ILogBook>();
        loggerMock.Setup(a => a.LogToDb(It.IsAny<string>())).Returns(true);

        loggerMock.Setup(a => a.LogBalanceAfterWithdrawl(It.Is<int>(a => a >= 0))).Returns(true);

        var bankAccount = new BankAccount(loggerMock.Object);

        bankAccount.Deposit(balance);
        var result = bankAccount.Withdraw(amount);

        Assert.That(result, Is.True);
    }
}
