using FluentAssertions;
using Formintech.Model;
using System;
using Xunit;

namespace Formintech.Tests
{
    public class FormTests
    {
        [Fact]
        public void CreateForm()
        {
            Form form = new Form();
            form.Title.Should().BeNull();

            form.Title="MyForm";
            form.Title.Should().Be("MyForm");
        }

        [Fact]
        public void CreateFormQuestions()
        {
            Form form = new Form()
            {
                Title = "MyForm"
            };
            form.Question.Title = "MyForm";

            form.Title.Should().Be(form.Question.Title);

            OpenQuestion qOpen = (OpenQuestion)form.Question.AddNewQuestion(typeof(OpenQuestion));
            qOpen.Should().NotBeNull();

            qOpen.Title = "Question basique";
            qOpen.Title.Should().Be("Question basique");

            QuestionBase qBase = form.Question.AddNewQuestion(typeof(OpenQuestion));
            qBase.Should().NotBeNull();

            QuestionBase qBase2 = form.Question.AddNewQuestion(typeof(OpenQuestion));




        }
    }
}
