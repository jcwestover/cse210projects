public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }

}