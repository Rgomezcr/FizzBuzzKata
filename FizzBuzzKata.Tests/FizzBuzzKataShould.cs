using System;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzKataShould
    {
        [Fact]
        public void CheckIfNumberThreeIsMultipleOfThree()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 3;

            int result = fizzBuzzKata.CalculateMultipleOfNumber(number);
            
            Assert.Equal(0, result);
        }
    }

}
