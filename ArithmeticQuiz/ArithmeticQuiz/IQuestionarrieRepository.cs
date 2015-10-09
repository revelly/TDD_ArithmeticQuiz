using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArithmeticQuiz
{
    public interface IQuestionarrieRepository
    {

        bool StoreQuestion(string question, List<string> options, string answer);
    }
}
