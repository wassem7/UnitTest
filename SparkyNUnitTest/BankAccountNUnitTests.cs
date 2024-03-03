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

    [Test]
    [TestCase(200, 400)]
    public void BankWithdrawl_Balance_of_200_Withdrawl_of_400(int balance, int amount)
    {
        var loggerMock = new Mock<ILogBook>();
        loggerMock.Setup(c => c.LogToDb(It.IsAny<string>())).Returns(true);
        loggerMock.Setup(c => c.LogBalanceAfterWithdrawl(It.Is<int>(i => i < 0))).Returns(true);

        var bankAccount = new BankAccount(loggerMock.Object);

        bankAccount.Deposit(200);
        var result = bankAccount.Withdraw(400);

        Assert.That(result, Is.True);
    }

    [Test]
    public void DummyLog_Test_Message_With_Str()
    {
        var desiredOutput = "kwame";

        var loggerMocker = new Mock<ILogBook>();
        loggerMocker.Setup(m => m.MessageWithStr(It.IsAny<string>())).Returns((string str) => str);

        Assert.That(loggerMocker.Object.MessageWithStr("kwame"), Is.EqualTo(desiredOutput));
    }

    [Test]
    public void DummyLog_Test_Log_Severiity_and_Log_Type()
    {
        var logMocker = new Mock<ILogBook>();

        logMocker.Setup(c => c.LogSeverity).Returns(1);
        logMocker.Setup(c => c.LogType).Returns("warning");

        Assert.That(logMocker.Object.LogType, Is.EqualTo("warning"));
        Assert.That(logMocker.Object.LogSeverity, Is.EqualTo(1));

        //callbacks
        string tempMessage = "Hello, ";
        logMocker
            .Setup(c => c.LogToDb(It.IsAny<string>()))
            .Returns(true)
            .Callback((string str) => tempMessage += str);
        logMocker.Object.LogToDb("Kwame");
        Assert.That(tempMessage, Is.EqualTo("Hello, Kwame"));
    }
}
