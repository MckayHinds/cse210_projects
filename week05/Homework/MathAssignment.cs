public class MathAssignment : Assignment
{
    //extra details
    private string _textbookSection;
    private string _problems;

    //first two values go to base class
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return "Section " + _textbookSection + " Problems " + _problems;
    }
}