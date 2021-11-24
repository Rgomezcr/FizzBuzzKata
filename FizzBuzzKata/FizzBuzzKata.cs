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
            if (number == 1)
                return "1";
            if (number == 2)
                return "2";
            if (number == 3)
                return "Fizz";
            return "4";
        }
    }
}
