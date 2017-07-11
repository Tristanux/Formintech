using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DForm
{
    public class QuestionRoot : QuestionBase
    {
        Form _form;
        public override Form Form { get => _form; }

        public QuestionRoot( QuestionBase parent, Form form ) : base(parent)
        {
            _form = form ?? throw new ArgumentNullException( "Form is nul" );
            Parent = null;
        }

        public override AnswerBase CreateAnswer()
        {
            throw new NotImplementedException();
        }

        public QuestionBase AddNewQuestion(Type questionType )
        {
            var createdQuestion = AddChild( questionType );
            return createdQuestion;
        }

        public QuestionBase AddNewQuestion( string questionType )
        {
            var createdQuestion = AddChild( Type.GetType(questionType) );
            return createdQuestion;
        }
    }
}
