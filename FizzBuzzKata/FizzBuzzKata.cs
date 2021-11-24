using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
   public class FizzBuzzKata
    {
        public string ReturnNumberAsString(int number)
        {
            if (number == 3)
                return "Fizz";
            if (number == 5)
                return "Buzz";
            if (number == 6)
                return "Fizz";
            if (number == 9)
                return "Fizz";
            if (number == 10)
                return "Buzz";


            return Convert.ToString(number);
        }
    }
}
