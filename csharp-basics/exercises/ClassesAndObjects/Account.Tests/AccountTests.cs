using System;
using Account.Exceptions;
using Xunit;

namespace Account.Tests
{
    public class AccountTests
    {
        private Account _target;

        public AccountTests()
        {
            _target = new Account("Kirill", 250.50m);
        }

        [Fact]
        public void Withdrawal_50_BalanceShouldBeEqualsTo200Point50()
        {
            //Arrange
            var expected = 200.50m;

            //Act
            _target.Withdrawal(50);

            //Asserts
            Assert.Equal(expected, _target.GetBalance());
        }

        [Fact]
        public void Withdrawal_500_ShouldThrowInsufficientFundsException()
        {
            //Act
            Action act = () => _target.Withdrawal(500);

            //Asserts
            Assert.Throws<InsufficientFundsException>(act);
        }

        [Fact]
        public void Deposit_250_BalanceShouldBeEqualsTo500Point50()
        {
            //Arrange
            var expected = 500.50m;

            //Act
            _target.Deposit(250);

            //Asserts
            Assert.Equal(expected, _target.GetBalance());
        }

        [Fact]
        public void Deposit_Minus500_ShouldThrowNegativeDepositException()
        {
            //Act
            Action act = () => _target.Deposit(-500);

            //Asserts
            Assert.Throws<NegativeDepositException>(act);
        }

        [Fact]
        public void ToString_Kirill_250Point50_ShouldReturnStringWithBalanceInfo()
        {
            //Arrange
            var expected = "Kirill: 250.50";

            //Act
            var actual = _target.ToString();

            //Asserts
            Assert.Equal(expected, actual);
        }
    }
}
