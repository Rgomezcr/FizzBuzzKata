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
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            if (number % 5 == 0)
                return "Buzz";
            if (number % 3 == 0)
                return "Fizz";
            return Convert.ToString(number);
        }
    }
}
