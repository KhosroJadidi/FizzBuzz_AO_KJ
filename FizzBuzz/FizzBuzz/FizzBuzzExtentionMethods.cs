using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzzExtentionMethods
    {
        public static  string CheckForFizz(this int value)
        {
            if (value % 3 == 0)
                return "Fizz";
            return String.Empty;
        }

        public static string CheckForBuzz(this int value)
        {
            if (value % 5 == 0)
                return "Buzz";
            return String.Empty;
        }

        public static string GetAnswerOfLife(this int value)
        {
            if (value == 42)
                return "Answer to the Ultimate Question of Life, the Universe, and Everything";
            return String.Empty;
        }
    }
}
