using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DForm
{
    public class FormAnswer
    {
        public string Respondant { get; set; }

        public List<AnswerBase> Answers { get; set; }

        public FormAnswer(string respondant)
        {
            Respondant = respondant ?? throw new ArgumentException(nameof(respondant));
            Answers = new List<AnswerBase>();
        }

        public AnswerBase FindAnswer(QuestionBase question)
        {
            return Answers.SingleOrDefault( a => a.Question == question );
        }

        public AnswerBase AddAnswerFor(QuestionBase question )
        {
            // Will throw an exception if the question does no exist in the form answer
            //Answers.Select( a => a.Question ).Single( q => q == question );
            question.Response = question.CreateAnswer();
            Answers.Add( question.Response );
            return question.Response;
        } 
    }
}
