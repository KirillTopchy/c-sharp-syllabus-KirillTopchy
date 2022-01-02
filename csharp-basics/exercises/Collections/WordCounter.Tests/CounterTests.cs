using System;
using System.IO;
using WordCount;
using Xunit;

namespace WordCounter.Tests
{
    public class CounterTests
    {
        [Fact]
        public void CountLines_string_ShouldReturn6()
        {
        //Arrange
            var CurrentDir = Directory.GetCurrentDirectory().Replace("\\WordCounter.Tests\\bin\\Debug\\net5.0", "");
            var Path = (CurrentDir + "\\WordCount\\lear.txt");
            var expected = 6;

        //Act
        var actual = Counter.CountLines(Path);

        //Assert
        Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountWords_string_ShouldReturn43()
        {
            //Arrange
            var CurrentDir = Directory.GetCurrentDirectory().Replace("\\WordCounter.Tests\\bin\\Debug\\net5.0", "");
            var Path = (CurrentDir + "\\WordCount\\lear.txt");
            var expected = 43;

            //Act
            var actual = Counter.CountWords(Path);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountChars_string_ShouldReturn198()
        {
            //Arrange
            var CurrentDir = Directory.GetCurrentDirectory().Replace("\\WordCounter.Tests\\bin\\Debug\\net5.0", "");
            var Path = (CurrentDir + "\\WordCount\\lear.txt");
            var expected = 198;

            //Act
            var actual = Counter.CountChars(Path);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
