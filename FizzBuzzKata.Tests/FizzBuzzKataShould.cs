using System;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzKataShould
    {
        [Fact]
        public void CheckIfNumberIsMultipleOfThree()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 3;
            int result = fizzBuzzKata.CalculateMultipleOfNumber(number);
            Assert.Equal(3, result);
        }
    }

}
