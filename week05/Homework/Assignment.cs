public class Assignment
{
    //store basic info that all assignments have
    private string _studentName;
    private string _topic;
    //base assignment with name/topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }

    //summary
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}
