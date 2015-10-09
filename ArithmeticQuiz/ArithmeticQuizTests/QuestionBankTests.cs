using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticQuiz;

namespace ArithmeticQuizTests
{
    [TestClass]
    public class QuestionBankTests
    {
        QuestionBank questionBank;

        [TestInitialize]
        public void getQuestion()
        {
            questionBank = new QuestionBank();
        }


        [TestMethod]
        public void TestIfQuestionBankObjectISNotNull()
        {
            
            Assert.IsNotNull(questionBank);
        }
    }
}
