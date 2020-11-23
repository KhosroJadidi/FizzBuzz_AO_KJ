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
                string text = string.Empty;

                text = i.CheckForFizz(text);
                text = i.CheckForBuzz(text);
                text = i.CheckForFizzBuzz(text);
                text = i.GetAnswerOfLife(text);
                text = i.GetIndex(text);

                Console.WriteLine(text);
            }
        }        
    }
}
