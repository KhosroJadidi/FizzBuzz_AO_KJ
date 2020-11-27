using System;
using System.IO;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.PrintFizzBuzz(program.GetFizzBuzzLength());
        }

        public void PrintFizzBuzz(int FizzBuzzLength)
        {
            for (int i = 1; i <= FizzBuzzLength; i++)
            {
                string output = string.Empty;

                output = i.CheckForFizz(output);
                output = i.CheckForBuzz(output);
                output = i.CheckForFizzbuzz(output);
                output = i.GetAnswerOfLife(output);
                output = i.GetIndex(output);

                Console.WriteLine(output);
            }
        }

        public int GetFizzBuzzLength()
        {
            string input;
            bool correctInput = false;
            int FizzBuzzLength = 1;

            Console.Write("Please write a number between 1-300 and press enter: ");

            while (!correctInput)
            {
                input = Console.ReadLine();
                correctInput = int.TryParse(input, out FizzBuzzLength) && FizzBuzzLength < 300 && FizzBuzzLength > 1;
                if (!correctInput)
                {
                    Console.Write("Incorrect input! Please try again: ");
                }
            }

            return FizzBuzzLength;
        }
    }
}
