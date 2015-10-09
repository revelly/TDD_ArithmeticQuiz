using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArithmeticQuiz
{
   public class QuestionBank: IQuestionBank
    {
       List<Question> Questions;
        public List<Question> getQuestions()
        {
            Questions = new List<Question>();
            return Questions;
        }

    }
}
