namespace SscupClassLibrary
{
    internal abstract class Question
    {
        protected int ID { get; set; }
        protected string Text { get; set; }
        protected QuestionType Type { get; set; }
    }


    public enum QuestionType
    {
        // Typ av frågor
    }
}
