using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.PrintFizzBuzz();

            //PrintFizzBuzz();
        }

        public void PrintFizzBuzz()
        {
            for (int i = 1; i < 300; i++)
            {

                string text = string.Empty;
                if (i % 3 == 0)
                    text += "Fizz";
                if (i % 5 == 0)
                    text += "Buzz";
                if (i == 42)
                    text = "Answer to the Ultimate Question of Life, the Universe, and Everything";
                if (text.Length == 0)
                    text = i.ToString();

                Console.WriteLine(text);
            }
        }
    }
}
