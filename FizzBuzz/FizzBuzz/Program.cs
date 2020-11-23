using System;


namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.PrintFizzBuzz();
        }

        public void PrintFizzBuzz()
        {
            for (int i = 1; i < 300; i++)
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
    }
}
