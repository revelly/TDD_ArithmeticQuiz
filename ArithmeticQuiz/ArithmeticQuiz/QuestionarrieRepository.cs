using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace ArithmeticQuiz
{
    public class QuestionarrieRepository : IQuestionarrieRepository
    {

        public bool StoreQuestion(string question, List<string> options, string answer)
        {
            return false;
        }

        private string ConverToJSON(string question, List<string> options, string answer)
        {

        //  Question questionnaire = new Question();
          //questionnaire.


         // JsonConvert.SerializeObject(questionnaire);
            string ret="";
            return ret;
        }
    }
}
