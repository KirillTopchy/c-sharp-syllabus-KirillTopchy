using System;
using Exercise_5;
using Xunit;

namespace Exercise5.Tests
{
    public class DateTests
    {
        private Date _date;
        public DateTests()
        {
            _date = new Date(8, 3, 1994);
        }

        [Fact]
        public void GetDate_8_3_1994_ShouldBeEqual()
        {
            //Arrange
            var expected = "3/8/1994";

            //Act
            var actual = _date.GetDate();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
