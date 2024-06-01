public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;
    public Video()
    {
        _comments = new List<Comment>();
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title}\nAuthor{_author}, Length (in seconds): {_length},\nNumber of Comments: {_comments.Count}");
        Console.WriteLine("\nComments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment._personName}: {comment._textComment}");
        }
    }
}