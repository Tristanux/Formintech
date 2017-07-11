using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace DForm.Tests
{
    [TestFixture]
    public class FormTests
    {
        [Test]
        public void CreateForm()
        {
            Form form = new Form();
            form.Title.Should().BeNull();

            form.Title = "MyForm";
            form.Title.Should().Be( "MyForm" );
        }

        [Test]
        public void CreateFormQuestions()
        {
            Form form = new Form();
            form.Questions.Title = "MyForm";

            form.Title.Should().Be( form.Questions.Title );

            OpenQuestion qOpen = (OpenQuestion)form.Questions.AddNewQuestion( typeof( OpenQuestion ) );
            qOpen.Should().NotBeNull();

            qOpen.Title = "Question basique";
            qOpen.Title.Should().Be( "Question basique" );

            QuestionBase qBase = form.Questions.AddNewQuestion( typeof( OpenQuestion ) );
            qBase.Should().NotBeNull();

            QuestionBase qBase2 = form.Questions.AddNewQuestion( typeof( OpenQuestion ) );
        }

        [Test]
        public void Totale()
        {
            Form form = new Form();
            
            OpenQuestion qOpen = (OpenQuestion)form.Questions.AddNewQuestion( typeof( OpenQuestion ) );
            OpenQuestion qOpen2 = (OpenQuestion)form.Questions.AddNewQuestion( "DForm.OpenQuestion, DForm" );
            qOpen.Should().NotBeNull();
            qOpen2.Should().NotBeNull();

            qOpen.Title = "Question basique";
            qOpen.Title.Should().Be( "Question basique" );
            qOpen.AllowEmptyAnswer = false;

            FormAnswer formAnswer = form.CreateAnswer( "Tristan" );
            AnswerBase answer = formAnswer.FindAnswer( qOpen );
            if(answer == null )
            {
                answer = formAnswer.AddAnswerFor( qOpen );
            }

            Assert.IsInstanceOfType( typeof( OpenAnswer ), answer );
        }
    }
}
