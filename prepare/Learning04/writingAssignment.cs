public class writingAssignment : Assignment{
    private string _title;

    public writingAssignment(string studentName, string topic, string title) : base(studentName, topic){
        _title = title;
    }

    public string _GetWritingInformation(){
        return _title + " by " + _studentName;
    }

}