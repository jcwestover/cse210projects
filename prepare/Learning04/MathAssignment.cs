public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problems)
        : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetSection()
    {
        return _textbookSection;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()\n Section {_textbookSection}};"
    }

}