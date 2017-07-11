using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DForm
{
    public class OpenQuestion : QuestionBase
    {
        public bool AllowEmptyAnswer { get; set; }
        public OpenAnswer Answer { get; set; }
        public OpenQuestion( QuestionBase parent ) : base( parent )
        {
        }

        public override AnswerBase CreateAnswer()
        {
            Answer = new OpenAnswer();
            return Answer;
        }
    }
}
