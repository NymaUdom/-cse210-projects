public class WritingAssignment : Assignment
{
    // Additional attribute specific to WritingAssignment
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method to get writing information including title and student's name
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
