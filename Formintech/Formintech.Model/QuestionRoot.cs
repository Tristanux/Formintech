using System;
using System.Collections.Generic;
using System.Text;

namespace Formintech.Model
{
    public class QuestionRoot : QuestionBase
    {
        Form _form;
        public new Form Form { get => _form; }

        public QuestionRoot(Form form)
        {
            if (form == null) throw new ArgumentNullException("Form is nul");
            _form = form;
        }



    }
}
