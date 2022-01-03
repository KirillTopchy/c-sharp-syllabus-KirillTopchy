using System;
using Xunit;

namespace Exercise1.Tests
{
    public class ProductTests
    {
        private Product _target;

        public ProductTests()
        {
            _target = new Product("IPad", 999.99, 2);
        }

        [Fact]
        public void GetProduct_IPad_999Point99_2_ShouldReturnProduct()
        {
            //Arrange
            var expected = "IPad, price 999.99, amount 2";

            //Act
            var result = _target.GetProduct();

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
