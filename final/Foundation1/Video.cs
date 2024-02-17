public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    
    public Video(string title, string author, int length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }

    public int GetNumberComments()
    {
        return _comments.Count();
    }

    public void Display()
    {
        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"        Title: {_title}");
        Console.WriteLine($"        Author: {_author}");
        Console.WriteLine($"        Length (seconds): {_length}");
        Console.WriteLine($"        Number of comments: {GetNumberComments()}");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        foreach (Comment x in _comments)
        {
            Console.WriteLine("");
            x.PrintFormattedString();
        }
        Console.WriteLine("\n\n");
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}