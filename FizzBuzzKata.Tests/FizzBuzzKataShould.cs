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
        public void ReturnThreeAsStringFizz()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 3;

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ReturnFiveAsStringBuzz()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 5;

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ReturnSixAsStringFizz()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 6;

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ReturnSevenAsString()
        {
            FizzBuzzKata fizzBuzzKata = new FizzBuzzKata();
            int number = 7;

            string result = fizzBuzzKata.ReturnNumberAsString(number);

            Assert.Equal("7", result);
        }

    }

}
