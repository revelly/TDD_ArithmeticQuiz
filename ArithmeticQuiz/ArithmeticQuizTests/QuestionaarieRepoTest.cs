using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticQuiz;

namespace ArithmeticQuizTests
{
    [TestClass]
    public class QuestionaarieRepoTest
    {
        public IQuestionarrieRepository questRepo { get; set; }
        bool? IsStored = null;

        [TestInitialize]
        public void TestSetUp()
        {
            questRepo = new QuestionarrieRepository();
            IsStored = false;
        }

        [TestMethod]
        public void TestIfquestRepoIsNotNull()
        {
            Assert.IsNotNull(questRepo);
        }
        [TestMethod]
        public void TestIfQuestionIsStored()
        {
            string question = "1+1=";
            List<string> options = new List<string>();
            options.Add("1");
            options.Add("2");
            options.Add("3");
            options.Add("4");
            string answer = "2";
            bool IsStored = questRepo.StoreQuestion(question, options, answer);
            Assert.IsTrue(IsStored);

        }

        
    }
}
