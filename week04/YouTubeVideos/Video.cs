public class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        foreach (var comment in comments)
        {
            Console.WriteLine($" - {comment.GetDisplay()}");
        }
        Console.WriteLine();
    }
}
