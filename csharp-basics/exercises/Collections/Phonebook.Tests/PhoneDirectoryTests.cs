using System;
using System.Collections.Generic;
using PhoneBook;
using Phonebook.Exceptions;
using Xunit;

namespace Phonebook.Tests
{
    public class PhoneDirectoryTests
    {
        private PhoneDirectory _target;

        [Fact]
        public void Setup()
        {
            _target = new PhoneDirectory();
        }

        [Fact]
        public void PutNumber_Kirill_123456789_ShouldAddInfoToDictionary()
        {
            //Arrange
            Setup();
            var expected = "123456789";

            //Act
            _target.PutNumber("Kirill", "123456789");

            //Assert
            Assert.Equal(expected,_target.GetNumber("Kirill"));
        }

        [Fact]
        public void GetNumber_Kirill_ShouldBeNull()
        {
            //Arrange
            Setup();

            //Act
            var number = _target.GetNumber("Kirill");

            //Assert
            Assert.Null(number);
        }

        [Fact]
        public void PutNumber_Kirill_Null_ShouldThrowNullNumberException()
        {
            //Arrange
            Setup();

            //Act
            Action act = () => _target.PutNumber("Kirill", null);

            //Assert
            Assert.Throws<NumberIsNullException>(act);
        }

        [Fact]
        public void PutNumber_Null_123456789_ShouldThrowNullNameException()
        {
            //Arrange
            Setup();

            //Act
            Action act = () => _target.PutNumber(null, "123456789");

            //Assert
            Assert.Throws<NameIsNullException>(act);
        }

        [Fact]
        public void PutNumber_Kirill_7777777_ShouldReplaceNumberInDictionary()
        {
            //Arrange
            Setup();
            _target.PutNumber("Kirill", "123456789");
            var expected = "7777777";

            //Act
            _target.PutNumber("Kirill", "7777777");

            //Assert
            Assert.Equal(expected, _target.GetNumber("Kirill"));
        }
    }
}
