using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("peep", true)]
        [InlineData("dud", true)]
        [InlineData("anna", true)]
        [InlineData("civic", true)]
        [InlineData("kayak", true)]
        [InlineData("doughnut", false)]
        [InlineData("dude", false)]
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
