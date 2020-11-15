namespace SscupClassLibrary
{
    public abstract class Question
    {
       // protected int ID { get; set; }
        protected string Text { get; set; }bool  

        protected Question(int id, string text)
        {
            //ID = id;
            Text = text;
        }
        
        protected Question(string text)
        {
            Text = text;
        }
    }

}
