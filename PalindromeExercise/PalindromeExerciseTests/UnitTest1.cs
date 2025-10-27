using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("peep", true)]
        [InlineData("other", false)]
        public void IsAPalindrome(string word, bool expected)
        {
            
            //Arrange

            var input = new WordSmith();

            //Act
            
            bool actual = input.IsPalindrome(word);
            

            //Assert
            
            Assert.Equal(expected, actual);



        }
      
    }
}
