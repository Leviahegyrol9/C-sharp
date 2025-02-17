using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talalos
{
    public class Question
    {
        public string QuestionName { get; set; }
        public string QuestionAnswer { get; set; }

        public Question()
        {
            
        }
        public Question(string questionName, string questionAnswer)
        {
            QuestionName = questionName;
            QuestionAnswer = questionAnswer;
        }

        public override string ToString()
        {
            return $"{QuestionName}:{QuestionAnswer}";
        }
    }
}
