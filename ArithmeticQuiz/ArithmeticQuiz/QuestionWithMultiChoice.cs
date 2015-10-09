using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArithmeticQuiz
{
    public class QuestionWithMultiChoice : IQuestion
    {
        public int questionNo { get; set; }
        public string question { get; set; }
        public List<string> options { get; set; }

        public List<string> answer { get; set; }
        public string selectedOption { get; set; }

        public bool validateAnswer()
        {
            return true;
        }
    }
}
