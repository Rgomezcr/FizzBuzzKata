using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzzKata.Tests
{
    public class FizzBuzzKataShould
    {

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        [InlineData("4",4)]
        [InlineData("7",7)]
        [InlineData("8", 8)]
        public void ReturnNumberAsString(string expected, int number)
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal(expected, result);
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
