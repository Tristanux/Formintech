namespace DForm
{
    public abstract class AnswerBase
    {
        public string Title { get; set; }
        public QuestionBase Question { get; set; }
    }
}