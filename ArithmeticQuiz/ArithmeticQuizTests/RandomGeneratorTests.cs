using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticQuiz;

namespace ArithmeticQuizTests
{
    /// <summary>
    ///This is a test class for RandomGeneratorTest and is intended
    ///to contain all RandomGeneratorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RandomGeneratorTests
    {
        RandomGenerator target;

        [TestInitialize]
        public void getTarget()
        {
            target = new RandomGenerator(1, 100, 10);
        }

        [TestMethod]
        public void TestIfStartPointExists()
        {
            Assert.AreNotEqual(0, target.StartPoint);
        }

        [TestMethod]
        public void TestIfEndPointExists()
        {
            Assert.AreNotEqual(0, target.EndPoint);
        }

        [TestMethod]
        public void TestIfNoOfRandomCountsExists()
        {
            Assert.AreNotEqual(0, target.NoOfRandomCounts);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestIfStartPointIsLessThanEndPointThrowException()
        {
            target.StartPoint = 10;
            target.EndPoint = 1;
        }

        [TestMethod]
        public void TestIfgetRandomNumbersReturnsLengthAsNoOfRandomCounts()
        {
            target.NoOfRandomCounts = 10;

            List<int> randomNumbers = target.getRandomNumbers();

            Assert.AreEqual(randomNumbers.Count, target.NoOfRandomCounts);
        }

        [TestMethod]
        [Ignore]
        public void TestVerifyNumberWithinStartAndEndPoint()
        {
            int randomNumber = target.getRandomNumber();

            var result = (randomNumber > target.StartPoint ? (randomNumber < target.EndPoint ? true : false) : false);
            Assert.AreEqual(result, true);
        }

        
    }
}
