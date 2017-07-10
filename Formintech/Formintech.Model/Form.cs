using System;
using System.Collections.Generic;

namespace Formintech.Model
{
    public class Form
    {
        private QuestionRoot _questionRoot;

        public string Title { get => Question.Title; set => Question.Title = value; }
        public QuestionRoot Question { get => _questionRoot; set => _questionRoot = value; }

        public Form()
        {
            _questionRoot = new QuestionRoot(this);
        }

    }
}
