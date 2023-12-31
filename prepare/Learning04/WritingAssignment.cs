public class WritingAssignment : Assignment
{
    private string Title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        Title = title;
    }

    public string GetWritingInformation()
    {
        return $"{Title}";
    }
}