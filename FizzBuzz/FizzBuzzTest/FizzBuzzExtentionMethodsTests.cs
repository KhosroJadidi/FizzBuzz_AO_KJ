using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;


namespace FizzBuzzTest
{
    [TestClass]
    public class FizzBuzzExtentionMethodsTests
    {
        private string emptyString = string.Empty;
        private string fizz = "Fizz";
        private string buzz = "Buzz";
        private string fizzBuzz = "Fizzbuzz";
        private string answerOfLife  = 
            "Answer to the Ultimate Question of Life, the Universe, and Everything";

        [TestMethod]
        public void CheckForFizzCorrect()
        {
            var number = 3;
            var responseString = number.CheckForFizz(emptyString);
            Assert.AreEqual(fizz, responseString);
        }

        [TestMethod]
        public void CheckForBuzzCorrect()
        {
            var number = 5;
            var responseString = number.CheckForBuzz(emptyString);
            Assert.AreEqual(buzz, responseString);
        }

        [TestMethod]
        public void CheckForFizzBuzzCorrect()
        {
            var number = 15;
            var responseString = number.CheckForFizzbuzz(emptyString);
            Assert.AreEqual(fizzBuzz, responseString);
        }

        [TestMethod]
        public void CheckForFizzIncorrect()
        {
            var number = 4;
            var responseString = number.CheckForFizz(emptyString);
            Assert.AreNotEqual(fizz, responseString);
        }

        [TestMethod]
        public void CheckForBuzzIncorrect()
        {
            var number = 6;
            var responseString = number.CheckForBuzz(emptyString);
            Assert.AreNotEqual(buzz, responseString);
        }

        [TestMethod]
        public void CheckForFizzBuzzIncorrect()
        {
            var number = 16;
            var responseString = number.CheckForFizzbuzz(emptyString);
            Assert.AreNotEqual(fizzBuzz, responseString);
        }

        [TestMethod]
        public void GetAnswerOfLifeCorrect()
        {
            var number = 42;
            var responseString = number.GetAnswerOfLife(emptyString);
            Assert.AreEqual(answerOfLife, responseString);
        }

        [TestMethod]
        public void GetAnswerOfLifeIncorrect()
        {
            var number = 43;
            var responseString = number.GetAnswerOfLife(emptyString);
            Assert.IsTrue(responseString != answerOfLife);
        }

        [TestMethod]
        public void GetIndexTestEmptyString()
        {
            var number = 10;
            var response = number.GetIndex(emptyString);
            var expected = number.ToString();
            Assert.AreEqual(expected, response);
        }

        [TestMethod]
        public void GetIndexTestLoadedString()
        {
            var number = 10;
            var response = number.GetIndex(answerOfLife);
            var expected = answerOfLife;
            Assert.AreEqual(expected, response);
        }
    }
}
