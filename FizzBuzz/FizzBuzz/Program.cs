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
                string text;

                text = i.GetAnswerOfLife();
                if (text.Length == 0)
                {
                    text += i.CheckForFizz();
                    text += i.CheckForBuzz();
                }
                if (text.Length == 0)
                    text = i.ToString();

                Console.WriteLine(text);
            }
        }        
    }
}
