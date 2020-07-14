using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Level", true)]
        [InlineData("level", true)]
        [InlineData("Radar", true)]
        [InlineData("live", false)]
        public void PalindromeTester(string word, bool expected) 
        {
            //Arrange
            var sub = new WordSmith();

            //Actual
            var actual = sub.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }               
    }
}
