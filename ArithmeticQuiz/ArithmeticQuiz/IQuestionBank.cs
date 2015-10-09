using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArithmeticQuiz
{
    public interface IQuestionBank
    {
        List<IQuestion> getQuestions();
    }
}
