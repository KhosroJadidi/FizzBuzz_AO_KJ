using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzzExtentionMethods
    {
        public static  string CheckForFizz(this int value, string text)
        {
            if (value % 3 == 0)
                return "Fizz";
            return text;
        }

        public static string CheckForBuzz(this int value, string text)
        {
            if (value % 5 == 0)
                return "Buzz";
            return text;
        }

        public static string CheckForFizzBuzz(this int value, string text)
        {
            if (value % 3 == 0 && value % 5 == 0)
                return "Buzz";
            return text;
        }

        public static string GetAnswerOfLife(this int value, string text)
        {
            if (value == 42)
                return "Answer to the Ultimate Question of Life, the Universe, and Everything";
            return text;
        }

        public static string GetIndex(this int value, string text)
        {
            if (text.Length == 0)
                return value.ToString();
            return text;
        }
    }
}
