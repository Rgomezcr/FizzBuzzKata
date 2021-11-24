using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzKataShould
    {

        [Fact]
        public void ReturnOneAsString()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 1;

            string result = fizzBuzzKata.ReturnNumberAsString(number);
           
            Assert.Equal("1", result);
        }

        [Fact]
        public void ReturnTwoAsString()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 2;

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal("2", result);
        }

        [Fact]
        public void ReturnFourAsString()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 4;

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal("4", result);
        }

        [Fact]
        public void ReturnSevenAsString()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 7;

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal("7", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void ReturnMultipleOfFiveAsStringBuzz(int number)
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void ReturnMultipleOfThreeAsStringFizz(int number)
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void ReturnMultipleOfThreeAndFiveAsStringFizzBuzz(int number)
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal("FizzBuzz", result);
        }

    }

}
