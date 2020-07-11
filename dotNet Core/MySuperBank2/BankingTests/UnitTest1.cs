using System;
using Xunit;
using MySuperBank2;

namespace BankingTests
{
    public class BasicsTests
    {
        [Fact]
        public void TrueIsTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void CantTakeMoreThanYouHave()
        {
            // Test - exception is throwed for overdraft
            var account = new BankAccount("Kendra", 10000);
            Assert.Throws<InvalidOperationException>(
                () => account.MakeWithdrawl(75000,
                DateTime.Now,
                "Attempt to overdraw")
                );  
        }

        [Fact]
        public void NeedMoneyToStart()
        {
            // test inital balance is positive
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new BankAccount("inalid", -55)
                );
        }
    }
}
