using System;
using System.Collections.Generic;

namespace DForm
{
    public class Form
    {
        private QuestionRoot _questionRoot;

        public List<FormAnswer> FormAnswers { get; set; }
        public string Title { get => Questions.Title; set => Questions.Title = value; }
        public QuestionRoot Questions { get => _questionRoot; set => _questionRoot = value; }

        public Form()
        {
            _questionRoot = new QuestionRoot( null, this );
            FormAnswers = new List<FormAnswer>();
        }

        public FormAnswer CreateAnswer( string respondant )
        {
            FormAnswer answer = new FormAnswer(respondant);
            FormAnswers.Add( answer );
            return answer;
        }
    }
}
