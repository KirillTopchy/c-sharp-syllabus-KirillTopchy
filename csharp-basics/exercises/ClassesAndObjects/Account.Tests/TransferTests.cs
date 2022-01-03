using System;
using Xunit;

namespace Account.Tests
{
    public class TransferTests
    {
        private Account _target;
        private Account _target2;

        public TransferTests()
        {
            _target = new Account("Kirill", 250.50m);
            _target2 = new Account("Anton", 0);
        }

        [Fact]
        public void MoneyTransfer_target_target2_50Point50_target2BalanceShouldBe50Point50()
        {
            //Arrange
            var expected = 50.50m;

            //Act
            Transfer.MoneyTransfer(_target, _target2, 50.50m);

            //Asserts
            Assert.Equal(expected, _target2.GetBalance());
        }
    }
}
