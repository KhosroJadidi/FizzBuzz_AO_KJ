using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public static class FizzBuzzExtentionMethods
    {
        public static string CheckForFizz(this int value, string text)
        {
            if (value % 3 == 0)
                text = "Fizz";
            return text;
        }

        public static string CheckForBuzz(this int value, string text)
        {
            if (value % 5 == 0)
                text = "Buzz";
            return text;
        }

        public static string CheckForFizzbuzz(this int value, string text)
        {
            if (value % 3 == 0 && value % 5 == 0)
                text = "Fizzbuzz";
            return text;
        }

        public static string GetForAnswerOfLife(this int value, string text)
        {
            if (value == 42)
                text = "Answer to the Ultimate Question of Life, the Universe, and Everything";
            return text;
        }

        public static string GetIndex(this int value, string text)
        {
            if (text == string.Empty)
                text = value.ToString();
            return text;
        }
    }
}
