public class WritingAssignment : Assignment
{
    // Only writing assignments have a title
    private string _title;
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }
    //returns title and the student name together
    public string GetWritingInformation()
    {
        string name = GetStudentName();
        return _title + " by " + name;
    }
}
