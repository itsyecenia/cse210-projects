public class Videos{
    public string _title;
    public string _author;
    public int _seconds;
    public List<Comment> _comment = new List<Comment>();

    public void _displayInfo(){
        Console.WriteLine($"Video Info:\n{_title}\nBy {_author}\nLength in seconds: {_seconds}\n");
        Console.WriteLine($"Number of Comments: {_commentCount()}\n");
        _displayComments();
    }

    public void _addComment(string name, string text){
        _comment.Add(new Comment(name, text));
    }

    public int _commentCount(){
        int i = 0;
        foreach (Comment comment in _comment){
            i++;
        }
        return i;
    }

    public void _displayComments(){
        Console.WriteLine("Comments:\n");
        foreach (Comment comment in _comment){
            comment._getComment();
        }
    }

}