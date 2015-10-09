using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArithmeticQuiz
{
    public interface IQuestion
    {
        int questionNo { get; set; }
        string question { get; set; }
        List<string> options { get; set; }

        bool validateAnswer();
    }
}
