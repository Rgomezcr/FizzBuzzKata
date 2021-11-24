using System;
using System.Collections.Generic;
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

        [Fact]
        public void ReturnOneAsString()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 1;

            string result = fizzBuzzKata.ReturnNumberAsString(number);
           
            Assert.Equal("1", result);
        }
    }

}
