public class Assignment
{
    public Assignment()
    {}

    public Assignment(string studentname, string topic)
    {
        _studentName = studentname;
        _topic = topic;
    }
    private string _studentName = "";
    private string _topic = "";

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudent()
    {
        return _studentName;
    }

    public void SetStudent(string student)
    {
        _studentName = student;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }
}