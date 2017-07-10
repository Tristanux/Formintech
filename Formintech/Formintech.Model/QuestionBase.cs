using System;
using System.Collections.Generic;
using System.Text;

namespace Formintech.Model
{
    public class QuestionBase
    {


        List<QuestionBase> _questionsList;
        QuestionBase _parent;
        int _index;
        

        public string Title { get; set; }

        public int Index { get; }
        public QuestionBase Parent { get => _parent; set => _parent = value; }

        public Form Form { get => Parent.Form; }

        public QuestionBase()
        {
            _questionsList = new List<QuestionBase>();

        }

        public void SetIndex(int index)
        {

        }

        public QuestionBase AddNewQuestion(Type type)
        {
            var obj = (QuestionBase)Activator.CreateInstance(type);

            var nb = _questionsList.Count;
            obj.SetIndex(nb);

            _questionsList.Add(obj);
            
            return obj;
        }
    }
}
